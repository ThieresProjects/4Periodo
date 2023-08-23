using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pratica.Domain.Interface.Repository;
using Pratica.Domain.Interface.Service;
using Pratica.Infra;
using Pratica.Service;
using Pratica.WebApi.Mapping;

namespace Pratica.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
            builder.Services.AddScoped<IAlunoService, AlunoService>();
            builder.Services.AddSwaggerGen();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

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
        }
    }
}


