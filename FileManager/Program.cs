using Microsoft.AspNetCore; using Microsoft.AspNetCore.Hosting;  namespace FileManager {     public class Program     {         public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:44372")
                .Build();
        // В папке trash старый контроллер, он скрыт в данный момент, можно удалить
    }
}