using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LaQuiebraFront;
using LaQuiebraFront.Servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = builder.HostEnvironment.IsDevelopment()
    ? "http://localhost:5080"
    : builder.HostEnvironment.BaseAddress;
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(apiUrl) });
builder.Services.AddScoped<IRepositorio, Repositorio>();
builder.Services.AddScoped<Sesion>();

await builder.Build().RunAsync();
