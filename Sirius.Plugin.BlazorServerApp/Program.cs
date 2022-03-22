using Sirius.Api.Plugin;

namespace Sirius.Plugin.BlazorServerApp;

public class Program : IPlugin
{
    public Program(IServiceProvider serviceProvider)
    {
        SharedStartup.ServiceProvider = serviceProvider;
        var host = Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseContentRoot("plugins/SiriusAdministrationPanel");
                webBuilder.UseStartup<SharedStartup>();
            });
        Task.Run(() => host.Build().Run());
    }
}

public class AdministrationPanelPluginDefinition : IPluginDefinition
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        SharedStartup.ServiceCollection = serviceCollection;
    }

    public void OnServicesConfigured()
    {
    }

    public void OnServiceProviderBuild(IServiceProvider serviceProvider)
    {
    }

    public Type PluginClass() => typeof(Program);

    public string Name => "Sirius Administration Panel";
    public string Description => "";
    public string Author => "The General";
    public Version Version => new(1, 0, 0);
}