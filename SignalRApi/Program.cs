using Microsoft.EntityFrameworkCore;
using SignalRApi.DataAccess;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Visitor service
builder.Services.AddScoped<VisitorService>();

//Signalr
builder.Services.AddSignalR();

//postgresql connection
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
