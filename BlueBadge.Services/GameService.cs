﻿using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueBadge.Services
{
    public class GameService
    {

        private readonly Guid _userId;
        public GameService(Guid userId)
        {
            _userId = userId;
        }


        public bool CreateGame(GameCreate model)
        {
            var entity =
                new VideoGames()
                {
                    OwnerId = _userId,
                    GameTitle = model.GameTitle,
                    Console = model.Console,
                    GenreType = model.GenreType,
                    Price = model.Price,
                    ReleaseYear = model.ReleaseYear,
                    CreatedUtc = DateTimeOffset.Now,
                    Quantity = model.Quantity
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
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                    e =>
                       new GameList
                       {
                           GameId = e.GameId,
                           GameTitle = e.GameTitle,
                           Console = e.Console,
                           GenreType = e.GenreType,
                           ReleaseYear = e.ReleaseYear,
                           Quantity = e.Quantity,
                           Price = e.Price,
                           CreatedUtc = e.CreatedUtc,
                           ModifiedUtc = e.ModifiedUtc
                       }
                    );
                return query.ToArray();
            }
        }
        public GameDetails GetGameById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == id && e.OwnerId == _userId);
                return
                    new GameDetails
                    {
                        GameId = entity.GameId,
                        GameTitle = entity.GameTitle,
                        Console = entity.Console,
                        GenreType = entity.GenreType,
                        Price = entity.Price,
                        ReleaseYear = entity.ReleaseYear,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        
        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == model.GameId && e.OwnerId == _userId);

                entity.GameTitle = model.GameTitle;
                entity.GenreType = model.GenreType;
                entity.Console = model.Console;
                entity.Price = model.Price;
                entity.Quantity = model.Quantity;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGame(int gameId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VideoGame
                    .Single(e => e.GameId == gameId && e.OwnerId == _userId);
                ctx.VideoGame.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
