using Microsoft.AspNetCore.Builder;
using SGFP.Web.Configuration;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
// CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularPolicy", policy => {
        policy.WithOrigins(
             "http://localhost:4200",   // Angular dev
             "https://seusite.com.br"   // Angular prod

            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddFluentValidationAutoValidation();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint(
                $"/swagger/{description.GroupName}/swagger.json",
                $"API {description.GroupName.ToUpper()}"
            );
        }
    });
    app.MapOpenApi();
}
app.UseHttpsRedirection();
app.UseCors("AngularPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
