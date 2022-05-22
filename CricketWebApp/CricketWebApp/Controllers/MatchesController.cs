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
    public class MatchesController : ControllerBase
    {
        private readonly CricketDBContext _matchestablecontext;
        public MatchesController(CricketDBContext cricket)
        {
            _matchestablecontext = cricket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getTheCountry = _matchestablecontext.Country.ToList();
            return Ok(getTheCountry);
        }

        /*// GET: api/Matches/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Matches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
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
