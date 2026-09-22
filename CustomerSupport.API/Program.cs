using CustomerSupport.API.Extensions;
using CustomerSupport.Infrastructure.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//As Infrastructure project has the **DBContext** migration and update database commands will be run in the Infrastructure project.
//But connection string is in API project, we need to install Microsoft.entityframeworkcore.design nuget package in the API project
//Project having Microsoft.entityframeworkcore.design is scanned and connection string is read from that project.
//So we need to install Microsoft.entityframeworkcore.design nuget package in the API project.

var connectionString =
                builder.Configuration.GetConnectionString("CustomerSupportDBConnection")
                ?? throw new InvalidOperationException("CustomerSupportDBConnection is not configured.");
builder.Services.AddInfrastructureServices(connectionString);

// Register the application's global exception handler.
// This allows unhandled exceptions from the application
// to be processed by GlobalExceptionHandler.
builder.Services.AddGlobalExceptionHandling();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Add the global exception handling middleware to the HTTP request pipeline.
// When an unhandled exception occurs,
// ASP.NET Core forwards it to the registered exception handler.
app.UseExceptionHandler();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


