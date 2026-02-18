using AZ204Notes.Application.Interfaces;
using AZ204Notes.Application.UseCases;
using AZ204Notes.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Dependency Injection
builder.Services.AddScoped<IUserRepository, InMemoryUserRepository>();
builder.Services.AddScoped<UserService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();