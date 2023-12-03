using Microsoft.EntityFrameworkCore;
using Tribeca.WebAPI.Context;
using Tribeca.WebAPI.Services.Implementation;
using Tribeca.WebAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Fixing CORS issue for angular app 
builder.Services.AddCors(options=>options.AddPolicy(name: "TribecaOrigins",
    policy => 
    {
        policy.WithOrigins("http://localhost:4200", "http://localhost:9876", "http://localhost:5173").AllowAnyMethod().AllowAnyHeader();
    }));

builder.Services.AddDbContext<TribecaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IOfficeService, OfficeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("TribecaOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
