using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CricketWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET: api/Players
        private readonly CricketDBContext _playertablecontext;
        public PlayersController(CricketDBContext cricket)
        {
            _playertablecontext = cricket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getTheCountry = _playertablecontext.Country.ToList();
            return Ok(getTheCountry);
        }

        // GET: api/Players/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Players
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
