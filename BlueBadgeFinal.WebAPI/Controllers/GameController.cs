using BlueBadge.Models;
using BlueBadge.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BlueBadgeFinal.WebAPI.Controllers
{
    [Authorize]
    public class GameController : ApiController
    {
        private GameService CreateGameService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var gameService = new GameService(userId);
            return gameService;
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            
            GameService gameService = CreateGameService();
            var game = gameService.GetGames();
            return Ok(game);
        }
        [HttpPost]
        public IHttpActionResult Post(GameCreate game)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }
            var Service = CreateGameService();
            if (!Service.CreateGame(game))
            {
                return InternalServerError();
            }
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            GameService gameService = CreateGameService();
            var game = gameService.GetGameById(id);
            return Ok(game);
        }
        [HttpPut]
        public IHttpActionResult Put( [FromBody]GameEdit game)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            GameService service = CreateGameService();
           

            if (!service.UpdateGame(game))
                return InternalServerError();
                return Ok(game);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateGameService();
            if (!service.DeleteGame(id))
                return InternalServerError();
            return Ok();
        }
       
            
     
        

            

    }
}