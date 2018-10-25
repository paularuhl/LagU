using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LU.Core.Rest.Domain;
using LU.Core.Rest.Model;
using LU.Core.Rest.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LU.Core.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private readonly RestDbContext _context;

        public ScoresController(RestDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]ScoreModel model)
        {
            var player = _context.Players.Single(c => c.Id == model.PlayerId);
            var game = _context.Games.Single(c => c.Id == model.GameId);
            var playerGame = new PlayerGame
            {
                Game = game,
                Player = player,
                Kills = model.Kills,
                Deaths = model.Deaths,
                Assists = model.Assists
            };
            _context.Add(playerGame);
            _context.SaveChanges();

            return Created("", model);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ScoreModel model)
        {
            var playerGame = _context.PlayerGames.Single(c => c.Id == id);
            playerGame.Game = _context.Games.Single(c => c.Id == model.GameId);
            playerGame.Player = _context.Players.Single(c => c.Id == model.PlayerId);
            playerGame.Kills = model.Kills;
            playerGame.Deaths = model.Deaths;
            playerGame.Assists = model.Assists;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var playerGame = _context.PlayerGames.Single(c => c.Id == id);
            _context.Remove(playerGame);
            _context.SaveChanges();
            return Ok();
        }
    }
}