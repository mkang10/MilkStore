using MilkStoreWepAPI.DAO;
using MilkStoreWepAPI.Models;
using MilkStoreWepAPI.Repository;
using MilkStoreWepAPI.Service;
using Nest;

var builder = WebApplication.CreateBuilder(args);

bool isDevelop = builder.Environment.IsDevelopment();

if (isDevelop)
    Console.WriteLine("/* Development mode, using appsettings.Development.json");
else
    Console.WriteLine("/* Production mode, using appsettings.Docker.json");

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Add services to the container.
var settings = new ConnectionSettings(new Uri("http://localhost:9200/")).DefaultIndex("milkstore");

var client = new ElasticClient(settings);
builder.Services.AddScoped<IElasticsearchService<Article>, ElasticService<Article>>();
builder.Services.AddScoped<IElasticsearchService<User>, ElasticService<User>>();



builder.Services.AddSingleton(client);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
