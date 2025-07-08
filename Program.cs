using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using Temperance.Fallax.Services;
using Temperance.Fallax.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.Configure<AlphaVantageSettings>(
    builder.Configuration.GetSection("AlphaVantageSettings"));
builder.Services.AddScoped(sp => sp.GetRequiredService<IOptions<AlphaVantageSettings>>().Value);

builder.Services.AddHttpClient<INewsProvider, AlphaVantageNewsProvider>(client =>
{
    string conductorBaseUrl = builder.Configuration.GetSection("AlphaVantageSettings")["BaseUrl"]
                                ?? builder.Configuration["AlphaVantageSettings:BaseUrl"]
                                ?? throw new InvalidOperationException("Conductor API BaseUrl not found in Configuration (ConductorApi:BaseUrl or ConductorSettings:BaseUrl).");
    client.BaseAddress = new Uri(conductorBaseUrl);
    client.Timeout = TimeSpan.FromSeconds(30);
    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Luminara-MCP-Server", "1.0"));
});

builder.Services.AddSingleton<INewsProvider, AlphaVantageNewsProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
