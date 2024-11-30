using App_01_ServerManagement.Components;
using App_01_ServerManagement.Data;
using App_01_ServerManagement.Models;
using App_01_ServerManagement.StateStore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<ServerManagementContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs"));
});


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<SessionStorage>();
builder.Services.AddScoped<ContainerStorage>();
builder.Services.AddScoped<LondonOnlineServers>();
builder.Services.AddTransient<IServersEFCoreRepository, ServersEFCoreRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
