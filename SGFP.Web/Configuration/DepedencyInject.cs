using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using SGFP.Application.Interfaces;
using SGFP.Application.Mappings;
using SGFP.Application.Services;
using SGFP.Application.Validators;
using SGFP.Domain.Interfaces;
using SGFP.Infrastructure.Context;
using SGFP.Infrastructure.Repository;
using SGFP.Infrastructure.Security;


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
            services.AddScoped<ITB008_Categoria_DespesaRespository,TB008_Categoria_DespesaRespository>();
            services.AddScoped<ITB009_Tipo_DespesaRespository,TB009_Tipo_DespesaRespository>();
            services.AddScoped<ITB010_DespesaRepository, TB010_DespesaRepository>();
            services.AddScoped<ITB011_Categoria_Produto_CompraRepository, TB011_Categoria_Produto_CompraRepository>();
            services.AddScoped<ITB012_Unidade_Produto_CompraRepository, TB012_Unidade_Produto_CompraRepository>();
            services.AddScoped<ITB013_Item_Produto_CompraRepository, TB013_Item_Produto_CompraRepository>();
            services.AddScoped<ITB014_Item_CompraRepository, TB014_Item_CompraRepository>();
            services.AddScoped<ITB015_Status_PagamentoRepository, TB015_Status_PagamentoRepository>();

            //Services
            services.AddScoped<ITB003_Categoria_ReceitaServices,TB003_Categoria_ReceitaServices>();
            services.AddScoped<ITB004_Tipo_Origem_DinheiroService, TB004_Tipo_Origem_DinheiroService>();
            services.AddScoped<ITB005_RecebimentoService, TB005_RecebimentoService>();
            services.AddScoped<ITB006_FrequenciaService, TB006_FrequenciaService>();
            services.AddScoped<ITB007_ReceitaService, TB007_ReceitaService>();
            services.AddScoped<ITB008_Categoria_DespesaServices, TB008_Categoria_DespesaServices>();
            services.AddScoped<ITB009_Tipo_DespesaServices, TB009_Tipo_DespesaServices>();
            services.AddScoped<ITB010_DespesaServices, TB010_DespesaServices>();
            services.AddScoped<ITB011_Categoria_Produto_CompraServices, TB011_Categoria_Produto_CompraServices>();
            services.AddScoped<ITB012_Unidade_Produto_CompraService, TB012_Unidade_Produto_CompraService>();
            services.AddScoped<ITB013_Item_Produto_CompraServices, TB013_Item_Produto_CompraServices>();
            services.AddScoped<ITB014_Item_CompraServices, TB014_Item_CompraServices>();
            services.AddScoped<ITB015_Status_PagamentoService, TB015_Status_PagamentoService>();
            services.AddScoped<IDashBoardServices, DashBoardServices>();
            services.AddScoped<ITokenService, TokenService>();



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
