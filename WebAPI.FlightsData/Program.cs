using Microsoft.EntityFrameworkCore;
using WebAPI.FlightsData.Data;
using WebAPI.FlightsData.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); //swagger
builder.Services.AddSwaggerGen(); //swagger
builder.Services.AddControllers(); // added code
builder.Services.AddDbContext<FlightsDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFlightService, FlightService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
