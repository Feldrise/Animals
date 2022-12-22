using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Animals API",
        Description = "Une API pour récupérer des bruits d'animaux",
        Contact = new OpenApiContact
        {
            Name = "Victor (Feldrise) DENIS",
            Email = "contact@feldrise.com",
            Url = new Uri("https://feldrise.com")
        },
    });

    var filepath = Path.Combine(System.AppContext.BaseDirectory, "Animals.API.xml");
    c.IncludeXmlComments(filepath);
});

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
