using HelloWorldApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Force the app to listen on all interfaces (inside container)
builder.WebHost.UseUrls("http://0.0.0.0:80");

// Add DbContext service
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World");

app.Run();

