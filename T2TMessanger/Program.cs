using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using T2TMessanger;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Console.WriteLine("SS - 41");
Console.WriteLine("SS - 41");

Console.WriteLine("AZ - 61");
Console.WriteLine("AZ - 62");

Console.WriteLine("MAIN - 53");
await builder.Build().RunAsync();
