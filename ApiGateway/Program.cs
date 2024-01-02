using Ocelot.Middleware;

public class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        // Use Ocelot middleware
        await app.UseOcelot();

        app.Run();
    }
}