using System;
using GameStore.Data;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GenreEndpoints
{
    public static RouteGroupBuilder MapGenreEndpoints(this WebApplication app){
        var group = app.MapGroup("genres");
        group.MapGet("/", async(GameStoreContext dbContaxt)=> 
        await dbContaxt.Genres.Select(genre=>genre.ToDto()).AsNoTracking().ToListAsync());
        return group;
    }
}
