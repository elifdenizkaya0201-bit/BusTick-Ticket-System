using BustickWeb.Client.Pages;
using BustickWeb.Components;
using BustickWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Radzen;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<BustickWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BustickWebContext") ?? throw new InvalidOperationException("Connection string 'BustickWebContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRadzenComponents();

builder.Services.AddScoped<Radzen.TooltipService>();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()      
    .AddInteractiveWebAssemblyComponents();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()        
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BustickWeb.Client._Imports).Assembly);

app.Run();


