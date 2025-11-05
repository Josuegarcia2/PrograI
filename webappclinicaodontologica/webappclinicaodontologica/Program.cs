using Microsoft.EntityFrameworkCore;
using webappclinicaodontologica.Data; // Asegúrate de usar tu namespace real
using webappclinicaodontologica.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configurar servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Habilitar CORS para permitir llamadas desde login.html
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// 🔧 Configurar middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowAll"); // ✅ Activar CORS

app.UseAuthorization();

app.MapControllers();

// ✅ Si usas SPA o vistas estáticas
app.MapFallbackToFile("index.html");

app.Run();
