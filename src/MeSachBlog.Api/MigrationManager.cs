using MeSachBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace MeSachBlog.Api
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<MeSachContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}
