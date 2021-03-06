using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TodoWithScopedApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<TodoDbContext>(options => options.UseInMemoryDatabase("Todos"));

            var app = builder.Build();

            TodoApi.MapRoutes(app);

            await app.RunAsync();
        }
    }
}
