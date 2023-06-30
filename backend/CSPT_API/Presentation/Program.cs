
using Application.Interfaces;
using Application.Service;
using Infrastructure.Persistance;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration["DefaultConnection"];
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(connectionString));
            
            builder.Services.AddScoped<DbContext, AppDbContext>();
            // query
            builder.Services.AddScoped<IVentaQuery, VentaQuery>();

            // service

            builder.Services.AddScoped<IVentaService, VentaService>();

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}