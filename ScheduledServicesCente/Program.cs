using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//الاتصال مع قاعدة البيانات 
builder.Services.AddDbContext<DatabaseContext>(option =>
          option.UseSqlServer(builder.Configuration["ConnectionStrings:ScheduledServicesCenteDBConnection"]));
//جعل المتحول الذي يتم انشاءه من كلاس قاعدة البيانات عام لكل المشروع
builder.Services.AddScoped<DatabaseContext>();


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
