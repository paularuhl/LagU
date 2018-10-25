using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LU.Core.Rest.Domain;
using LU.Core.Rest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LU.Core.Rest.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly RestDbContext _context;

        public PlayersController(RestDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Players.Select(Formatter.FormatPlayer));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var player = _context.Players.Include(c => c.PlayerGames).ThenInclude(d => d.Game).Single(c => c.Id == id);
            var compiled = Formatter.FormatPlayer.Compile();
            return Ok(compiled.DynamicInvoke(player));
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Player model)
        {
            if(string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Country)) {
                return StatusCode(400);
            }
            _context.Add(model);
            _context.SaveChanges();

            return Created("", model);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Player model)
        {
            if(string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Country)) {
                return StatusCode(400);
            }
            var player = _context.Players.Single(c => c.Id == id);
            player.Name = model.Name;
            player.Country = model.Country;
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var player = _context.Players.Single(c => c.Id == id);
            _context.Remove(player);
            _context.SaveChanges();
            return Ok();
        }
    }
}
