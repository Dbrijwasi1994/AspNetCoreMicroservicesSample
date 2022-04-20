using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Ocelot.DependencyInjection;

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot(configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
