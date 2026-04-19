using CalculadoraComisiones.Application.Interfaces;
using CalculadoraComisiones.Application.Services;
using CalculadoraComisiones.Components;
using CalculadoraComisiones.Domain.Interfaces;
using CalculadoraComisiones.Domain.Rules;
using CalculadoraComisiones.Infrastructure.Abstractions;
using CalculadoraComisiones.Infrastructure.Providers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<ICommissionRule, IndiaCommissionRule>();
builder.Services.AddSingleton<ICommissionRule, UnitedStatesCommissionRule>();
builder.Services.AddSingleton<ICommissionRule, UnitedKingdomCommissionRule>();
builder.Services.AddSingleton<ICommissionRuleProvider, InMemoryCommissionRuleProvider>();
builder.Services.AddScoped<ICommissionCalculatorService, CommissionCalculatorService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
