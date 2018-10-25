using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LU.Core.Rest.Domain;
using LU.Core.Rest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LU.Core.Rest.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly RestDbContext _context;

        public GamesController(RestDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var games = _context.Games.Select(Formatter.FormatGame);
            return Ok(games);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var game = _context.Games.Include(c => c.PlayerGames).ThenInclude(d => d.Player).Single(c => c.Id == id);
            var compiled = Formatter.FormatGame.Compile();
            return Ok(compiled.DynamicInvoke(game));
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Game model)
        {
            model.StartDateTime = DateTime.Now;
            model.EndDateTime = DateTime.Now.AddMinutes(45);
            _context.Add(model);
            _context.SaveChanges();

            return Created("", model);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var game = _context.Games.Single(c => c.Id == id);
            _context.Remove(game);
            _context.SaveChanges();
            return Ok();
        }
    }
}
