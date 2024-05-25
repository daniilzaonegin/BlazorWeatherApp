using BlazorWeatherApp.Client.Services;
using BlazorWeatherApp.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
    .AddHttpClient<IWeatherService, ClientWeatherService>(
        c => c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();
