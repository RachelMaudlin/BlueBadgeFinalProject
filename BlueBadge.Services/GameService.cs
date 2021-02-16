using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueBadge.Services
{
    public class GameService
    {

        public int _gameId;
        

        public bool CreateGameById(GameCreate model)
        {
            var entity =
                new VideoGames()
                {
                    GameTitle = model.GameTitle,
                    Console =  model.Console,
                    GenreType = model.GenreType,
                    ReleaseYear = model.ReleaseYear,
                    CreatedUtc = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.VideoGame.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<GameList> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .VideoGame
                    .Where(e => e.GameId == _gameId)
                    .Select(
                    e =>
                       new GameList
                       {
                           GameId = e.GameId,
                           Quantity = e.Quantity,
                           GameTitle = e.GameTitle,
                           CreatedUtc = e.CreatedUtc
                       }
                    );
                return query.ToArray();
            }
        }
        public GameDetails GetGameById()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == _gameId);
                return
                    new GameDetails
                    {
                        GameId = entity.GameId,
                        GameTitle = entity.GameTitle,
                        Console = entity.Console,
                        GenreType = entity.GenreType,
                        ReleaseYear = entity.ReleaseYear,
                        IsOnline = entity.IsOnline,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateGame (GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == model.GameId);
                entity.GameId = model.GameId;
                entity.GameTitle = model.GameTitle;
                entity.Quantity = model.Quantity;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGame()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == _gameId);
                ctx.VideoGame.Remove(entity);
                   return ctx.SaveChanges() == 1;
            }
        }
    }
}
