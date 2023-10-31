using _2L1.Application.Services;
using _2L1.Domain.Interfaces.Services;
using _2L1.Domain.Interfaces.Repositories;
using _2L1.Infrastructure.Data.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using _2L1.Infrastructure.Data.Providers.MongoDB;
using _2L1.Infrastructure.Data.Providers.MongoDB.Interfaces;
using _2L1.Infrastructure.Data.Providers.MongoDB.Configurations;
using _2L1.Application.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoDatabaseSettings>(
    builder.Configuration.GetSection("MongoDatabaseSettings"));

builder.Services.AddSingleton<IMongoDatabaseSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDatabaseSettings>>().Value);

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));
//builder.Services.AddAutoMapper(typeof(DomainToCollection), typeof(CollectionToDomain));

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

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
