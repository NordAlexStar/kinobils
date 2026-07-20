using KinoRezervacija.Web.Components;
using KinoRezervacija.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<CinemaCatalogService>();
builder.Services.AddSingleton<BookingService>();
builder.Services.AddScoped<CustomerSession>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}


// Pārklāj MapStaticAssets ar fizisko wwwroot: jaunie plakāti ir pieejami arī pēc hot reload.
app.UseStaticFiles();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
