using System;
using GameStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
            : DbContext(options)
{
    public DbSet<Game> Games =>Set<Game>();

    public DbSet<Genre> Genres =>Set<Genre>();

    public DbSet<Employee> Employees =>Set<Employee>();
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new{Id = 1, Name = "Fighting"},
            new{Id = 2, Name = "Roleplaying"},
            new{Id = 3, Name = "Sports"},
            new{Id = 4, Name = "Racing"},
            new{Id = 5, Name = "Kids and Family"}
        );
        modelBuilder.Entity<Employee>().HasData(
            new {id = 1, name = "John", surname = "Doe", dayOfBorn = new DateTime(1980, 1, 1), vocation = "Cooker"}

        );
    }

    
}
