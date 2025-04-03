var builder = WebApplication.CreateBuilder(args);

builder.Services
.AddApiServices(builder.Configuration)
.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await app.InitialyzeDataBaseAsync();
}

app.UseApiServices();

app.Run();
