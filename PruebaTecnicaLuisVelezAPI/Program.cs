using PruebaTecnicaLuisVelezAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Necesario para hacer uso de la inyección de dependencias a travéz del constructor.
builder.Services.AddScoped<IOrderProcessor, OrderProcessor>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
