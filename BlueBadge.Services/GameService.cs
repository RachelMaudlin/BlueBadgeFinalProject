using BlueBadge.Data;
using BlueBadge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueBadge.Services
{
    public class GameService
    {

        public GameService _gameId = new GameService();
        

        public bool CreateGame(GameCreate model, int GameId)
        {
            var entity =
                new VideoGames()
                {
                    GameId = GameId,
                    GameTitle = model.GameTitle,
                    GameConsole = model.GameConsole,
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
                           GameTitle = e.GameTitle,
                           CreatedUtc = e.CreatedUtc

                       }

                    );
                return query.ToArray();
                    
                                                        

                
            }
                
               
                 
                
                

            
        }

     
    }
}
