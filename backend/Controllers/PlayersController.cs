using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicTacToe_BackEnd.Entities;
using TicTacToe_BackEnd.Models;
using TicTacToeBackend.Context;

namespace TicTacToe_BackEnd.Controllers
{
    [Route("[controller]")]
    [EnableCors("CORSPolicy")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public PlayersController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            

            return new string[] { "value1", "value2" };
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var player = _context.Players.Where(p => p.id == id).Include(p => p.address);


            return "value";
        }

        // POST api/<PlayersController>
        [HttpPost]
        public void Post([FromBody] PlayerViewModel value)
        {
            _context.Players.Add(new Player { name = value.name, email = value.email });
            _context.SaveChanges();


        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
