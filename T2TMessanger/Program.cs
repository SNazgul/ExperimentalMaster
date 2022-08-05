using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using T2TMessanger;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Console.WriteLine("SS - 11");
Console.WriteLine("SS - 12");

Console.WriteLine("AZ - 21");
Console.WriteLine("AZ - 22");

await builder.Build().RunAsync();
