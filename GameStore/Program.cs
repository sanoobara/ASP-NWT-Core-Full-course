using GameStore.Endpoints;
using GameStore.Data;
var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

builder.Services.AddCors();

var app = builder.Build();





app.MapGamesEndpoints();
app.MapGenreEndpoints();
app.MapEmployeeEndpoints();

await app.MigrateDbAsync();


app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.Run();
