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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


