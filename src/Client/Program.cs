using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Foodtruck.Client;
using MudBlazor.Services;
using Foodtruck.Shared.Formulas;
using Foodtruck.Client.Formulas;
using Foodtruck.Shared.Supplements;
using Foodtruck.Client.Supplements;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
/*builder.Services.AddHttpClient("Project.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Project.ServerAPI"));
*/
builder.Services.AddScoped<IFormulaService, FormulaService>();
builder.Services.AddScoped<ISupplementService, SupplementService>();

builder.Services.AddMudServices();
await builder.Build().RunAsync();
