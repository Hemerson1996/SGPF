using Microsoft.EntityFrameworkCore;
using SGFP.Application.Mappings;
using SGFP.Domain.Interfaces;
using SGFP.Infrastructure.Context;
using SGFP.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using FluentValidation;
using SGFP.Application.Interfaces;
using SGFP.Application.Services;
using SGFP.Application.Validators;


namespace SGFP.Web.Configuration
{
    public static class DepedencyInject
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppSGPFContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //Repository
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ITB003_Categoria_ReceitaRepository,TB003_Categoria_ReceitaRepository>();
            services.AddScoped<ITB004_Tipo_Origem_DinheiroRepository,TB004_Tipo_Origem_DinheiroRepository>();
            services.AddScoped<ITB005_RecebimentoRepository,TB005_RecebimentoRepository>();
            services.AddScoped<ITB006_FrequenciaRepository,TB006_FrequenciaRepository>();
            services.AddScoped<ITB007_ReceitaRepository,TB007_ReceitaRepository>();

            //Services
            services.AddScoped<ITB003_Categoria_ReceitaServices,TB003_Categoria_ReceitaServices>();
            services.AddScoped<ITB004_Tipo_Origem_DinheiroService, TB004_Tipo_Origem_DinheiroService>();
            services.AddScoped<ITB005_RecebimentoService, TB005_RecebimentoService>();
            services.AddScoped<ITB006_FrequenciaService, TB006_FrequenciaService>();
            services.AddScoped<ITB007_ReceitaService, TB007_ReceitaService>();



            //Registro do AutoMap em Application
            services.AddAutoMapper(cfg => { }, typeof(DomainProfile));

            //Validação do formulario Request
            services.AddValidatorsFromAssemblyContaining<TB003_Categoria_ReceitaRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<TB004_Tipo_Origem_DinheiroRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<TB005_RecebimentoRequestValidator>();


            //Configurar API

            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;

                //Métodos de leitura
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new UrlSegmentApiVersionReader(),
                    new HeaderApiVersionReader("x-api-version"),
                    new QueryStringApiVersionReader("api-version")
                    );
                options.RegisterMiddleware = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
            services.AddSwaggerGen();
            services.ConfigureOptions<SwaggerVersioningConfig>();
            return services;
        }
    }
}
