using Sirius.Plugin.BlazorServerApp;
using Sirius.Plugin.BlazorServerApp.Data;

var collection = new ServiceCollection();
collection.AddSingleton<WeatherForecastService>();
var provider = collection.BuildServiceProvider();

SharedStartup.ServiceCollection = collection;
SharedStartup.ServiceProvider = provider;

Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<SharedStartup>();
                }).Build().Run();

// Run Hosting when developing your application.
// You can substitute the used interfaces for mock implementations.
// This speeds up development so you dont continously have to rebuild, restart emulator etc.
// Also hot reload is available this way.