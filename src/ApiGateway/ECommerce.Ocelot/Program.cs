using Ocelot.DependencyInjection;
using Ocelot.Cache.CacheManager;
using Ocelot.Middleware;

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("ocelot.Development.json").Build();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot(configuration).AddCacheManager(settings => settings.WithDictionaryHandle()); ;

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
await app.UseOcelot();
app.Run();
