global using eCommerce.Models;
using System.Text.Json.Serialization;
using eCommerce.Api.Database;
using eCommerce.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

# region ConfigureService

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
    );


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<eCommerceContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("eCommerce"))
);

#endregion

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

#region Configure

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

#endregion