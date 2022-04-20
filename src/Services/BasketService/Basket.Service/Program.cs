using Basket.Service.GrpcServices;
using Basket.Service.Repositories;
using Discount.Grpc.Protos;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddStackExchangeRedisCache(options =>
{
	options.Configuration = builder.Configuration.GetValue<string>("CacheSettings:ConnectionString");
});
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

// Grpc Configuration
builder.Services.AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>(o => o.Address = new Uri(builder.Configuration["GrpcSettings:DiscountUrl"]));
builder.Services.AddScoped<DiscountGrpcService>();

//RabbitMQ
builder.Services.AddMassTransit(config =>
{
	config.UsingRabbitMq((ctx, cfg) =>
	{
		cfg.Host(builder.Configuration["EventBusSettings:HostAddress"]);
	});
});
builder.Services.AddOptions<MassTransitHostOptions>().Configure(options =>
{
	options.WaitUntilStarted = true;
	options.StartTimeout = TimeSpan.FromSeconds(10);
	options.StopTimeout = TimeSpan.FromSeconds(30);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
