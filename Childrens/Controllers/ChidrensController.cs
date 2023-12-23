using Childrens.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Childrens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChidrensController : ControllerBase
    {
        private static ChildrensService _context = new ChildrensService();
        
        //public static List<Children> Chidrens = new List<Children> { new Children { Id = 1, Name = "yosi" }, new Children { Id = 2, Name = "chaim" } };
        int id = _context.Childrens.Last().Id + 1;

        // GET: api/<ChidrensController>
        [HttpGet]
        public IEnumerable<Children> Get()
        {
            return _context.Childrens;
        }

        // GET api/<ChidrensController>/5
        [HttpGet("{id}")]
        public Children Get(int id)
        {
            //var selectChild = new Children { Id = 3, Name = "yoni" };
            var selectChild = _context.Childrens.Find(c => c.Id == id);
            return selectChild;
        }

        // POST api/<ChidrensController>
        [HttpPost]
        public void Post([FromBody] string name)
        {
            _context.Childrens.Add(new Children { Id = id, Name = name });
            id++;

        }

        // PUT api/<ChidrensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            var updateChild = _context.Childrens.Find(c => c.Id == id);
            updateChild.Name = name;
        }

        // DELETE api/<ChidrensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var updateChild = _context.Childrens.Find(c => c.Id == id);
            _context.Childrens.Remove(updateChild);

        }
    }
}
