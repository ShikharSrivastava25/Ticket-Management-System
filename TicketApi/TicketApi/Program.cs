var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
       p => p.WithOrigins("http://localhost:4200")
             .AllowAnyHeader()
             .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment()) 
{
    app.UseSwaggerUI();
    app.UseSwagger();
}

app.UseCors("AllowAngular");

app.MapControllers();

app.Run();
