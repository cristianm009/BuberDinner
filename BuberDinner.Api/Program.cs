using BuberDinner.Api.Middleware;
using BuberDinner.Application;
using BuberDinner.Infraestructure;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
                .AddApplication()
                .AddInfraestructure(builder.Configuration);

    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}