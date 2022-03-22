using SocialMedia.API.Controllers;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Se resuelven las dependencias
//Cada vez que el programa haga uso de la abstraccion IPostRepository se le va a entregar la instancia PostRepository
builder.Services.AddTransient<IPostRepository, PostRepository>();

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
