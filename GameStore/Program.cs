using GameStore.Endpoints;
using GameStore.Data;
var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);



var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenreEndpoints();

await app.MigrateDbAsync();
app.Run();
