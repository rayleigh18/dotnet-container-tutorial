var builder = WebApplication.CreateBuilder(args);

// Add this line to explicitly set the URLs
builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:5001");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    // Set the Swagger endpoint
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    // Set the Swagger UI at the root
    c.RoutePrefix = "swagger";
});

// Comment out HTTPS redirection for local development
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
