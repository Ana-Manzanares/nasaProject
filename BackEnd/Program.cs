using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TuProyecto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseWebRoot("frontend") // Ruta a la carpeta "frontend"
                .UseUrls("http://localhost:5000"); // Cambia el puerto si es necesario
    }
}
