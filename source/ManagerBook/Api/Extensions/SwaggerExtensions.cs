using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace ManagerBooks.Applications.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class SwaggerExtensions
    {
        public static void SwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "ManagerBooks.Api",
                        Version = "v1",
                        Description = "Sistema para empréstimo de livros",
                        Contact = new Contact
                        {
                            Name = "Jéssica Dias",
                            Url = "https://github.com/jeh-dias"
                        }
                    });

                string caminhoAplicacao =
                        PlatformServices.Default.Application.ApplicationBasePath;
                string nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                string caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        public static void SwaggerApplication(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Sistema de empréstimo de livros");

                c.RoutePrefix = "docs";
            });
        }
    }
}