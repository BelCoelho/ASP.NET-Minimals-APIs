using MinimalAPI.Infraestrutura.Db;
using MinimalAPI.DTOs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>(options => {options.UseMySql(builder.Configuration.GetConnectionString("mysql"),ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql")));});

app.MapGet("/", () => "Hello World!");

//recebe a função LoginDTO, que recebe o objeto loginDTO
app.MapPost("/login", (MinimalAPI.DTOs.LoginDTO loginDTO) => 
{
    if (loginDTO.Email == "teste@teste.com" && loginDTO.Senha == "12345") 
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();



