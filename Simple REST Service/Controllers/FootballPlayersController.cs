using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPlayer;
using Simple_REST_Service.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Simple_REST_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FBPlayersController : ControllerBase
    {
        private readonly FootBallPlayersManager _manager = new FootBallPlayersManager();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<FBPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public FBPlayer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public FBPlayer Post([FromBody] FBPlayer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public FBPlayer Put(int id, [FromBody] FBPlayer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public FBPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
