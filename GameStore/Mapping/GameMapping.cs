using System;
using GameStore.Dtos;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto game){
        return new Game()
        {    
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate
        };
    }
        public static Game ToEntity(this UpdateGameDto game, int id){
        
            return new Game()
            {    
                Id = id,
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate
            };
    }

    public static GameSummaryDto ToGameSummaryDto(this Game game){
        return new (
                game.Id,
                game.Name,
                game.Genre!.Name,
                game.Price,
                game.ReleaseDate
            );

    }
    public static GameDetailsDto ToGameDetailsDto(this Game game){
        return new (
                game.Id,
                game.Name,
                game.GenreId,
                game.Price,
                game.ReleaseDate
            );

    }
}

// public static class GameMapping
// {
//     // Преобразует объект CreateGameDto в сущность Game (используется при создании игры)
//     public static Game ToEntity(this CreateGameDto game)
//     {
//         return new Game()
//         {
//             // Устанавливаем название игры
//             Name = game.Name,
//             // Устанавливаем идентификатор жанра
//             GenreId = game.GenreId,
//             // Устанавливаем цену игры
//             Price = game.Price,
//             // Устанавливаем дату релиза игры
//             ReleaseDate = game.ReleaseDate
//         };
//     }

//     // Преобразует объект UpdateGameDto в сущность Game с добавлением идентификатора игры
//     public static Game ToEntity(this UpdateGameDto game, int id)
//     {
//         return new Game()
//         {
//             // Присваиваем идентификатор, переданный в метод
//             Id = id,
//             // Обновляем название игры
//             Name = game.Name,
//             // Обновляем идентификатор жанра
//             GenreId = game.GenreId,
//             // Обновляем цену игры
//             Price = game.Price,
//             // Обновляем дату релиза игры
//             ReleaseDate = game.ReleaseDate
//         };
//     }

//     // Преобразует сущность Game в объект GameSummaryDto (краткая информация об игре)
//     public static GameSummaryDto ToGameSummaryDto(this Game game)
//     {
//         return new (
//             // Используем идентификатор игры
//             game.Id,
//             // Используем название игры
//             game.Name,
//             // Извлекаем название жанра через навигационное свойство Genre
//             game.Genre!.Name,
//             // Используем цену игры
//             game.Price,
//             // Используем дату релиза
//             game.ReleaseDate
//         );
//     }

//     // Преобразует сущность Game в объект GameDetailsDto (детальная информация об игре)
//     public static GameDetailsDto ToGameDetailsDto(this Game game)
//     {
//         return new (
//             // Используем идентификатор игры
//             game.Id,
//             // Используем название игры
//             game.Name,
//             // Используем идентификатор жанра
//             game.GenreId,
//             // Используем цену игры
//             game.Price,
//             // Используем дату релиза
//             game.ReleaseDate
//         );
//     }
// }
