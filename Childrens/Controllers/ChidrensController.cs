using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Childrens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChidrensController : ControllerBase
    {
        public static List<Children> Chidrens = new List<Children> { new Children { Id = 1, Name = "yosi" }, new Children { Id = 2, Name = "chaim" } };
        int id = Chidrens.Last().Id + 1;

        // GET: api/<ChidrensController>
        [HttpGet]
        public IEnumerable<Children> Get()
        {
            return Chidrens;
        }

        // GET api/<ChidrensController>/5
        [HttpGet("{id}")]
        public Children Get(int id)
        {
            //var selectChild = new Children { Id = 3, Name = "yoni" };
            var selectChild = Chidrens.Find(c => c.Id == id);
            return selectChild;
        }

        // POST api/<ChidrensController>
        [HttpPost]
        public void Post([FromBody] string name)
        {
            Chidrens.Add(new Children { Id = id, Name = name });
            id++;

        }

        // PUT api/<ChidrensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            var updateChild = Chidrens.Find(c => c.Id == id);
            updateChild.Name = name;
        }

        // DELETE api/<ChidrensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var updateChild = Chidrens.Find(c => c.Id == id);
            Chidrens.Remove(updateChild);

        }
    }
}
