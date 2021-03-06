namespace Git
{
    using System.Threading.Tasks;
    using Git.Data;
    using Git.Services;
    using Microsoft.EntityFrameworkCore;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.Results.Views;

    public class Startup
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers())
                .WithServices(services => services
                    .Add<IPasswordHasher,PasswordHasher>()
                    .Add<IValidator,Validator>()
                    .Add<GitDbContext>()
                    .Add<IViewEngine, CompilationViewEngine>())
            .WithConfiguration<GitDbContext>(context => context
                    .Database.Migrate())
                .Start();
    }
}


