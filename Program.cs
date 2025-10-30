using Avalonia;
using Microsoft.EntityFrameworkCore;
using System;

namespace diet_planner;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        using (var ctx = new DietPlanner.DataAccess.DietContext())
        {
            bool canConnect = ctx.Database.CanConnect();
            Console.WriteLine($"EF CanConnect: {canConnect}");
            Console.WriteLine("Connection string: " + ctx.Database.GetDbConnection().ConnectionString);
        }
        BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
