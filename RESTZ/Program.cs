using Microsoft.EntityFrameworkCore;
using RESTZ.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string stringcon = builder.Configuration.GetValue<string>("motordb:stringcon");

builder.Services.AddDbContext<dbcontext>(con => con.UseSqlServer(stringcon));

builder.Services.AddCors(c => c.AddPolicy("RESTZ", builder =>
{
    builder.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
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
