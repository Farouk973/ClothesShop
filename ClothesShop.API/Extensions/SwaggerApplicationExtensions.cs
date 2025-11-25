using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClothesShop.API.Settings
{
    public static class SwaggerApplicationExtensions
    {
        // Middleware ONLY, works with WebApplication
        public static WebApplication UseSwaggerDocumentation(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Shop API V1");
                c.RoutePrefix = "swagger"; // Swagger will be available at /swagger
            });

            return app;
        }
    }
}
