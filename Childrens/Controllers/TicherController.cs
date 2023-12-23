using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Childrens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicherController : ControllerBase
    {
        private static DataContext _context = new DataContext();

        int id = _context.Tichers.Last().Id;

        // GET: api/<KinderGartenTicherController>
        [HttpGet]
        public List<Ticher> Get()
        {
            return _context.Tichers;
        }

        // GET api/<KinderGartenTicherController>/5
        [HttpGet("{id}")]
        public Ticher Get(int id)
        {
            var selectedTicher = _context.Tichers.Find(t => t.Id == id);
            return selectedTicher;
        }

        // POST api/<KinderGartenTicherController>
        [HttpPost]
        public void Post([FromBody] string name)
        {
            _context.Tichers.Add(new Ticher { Id = id, Name = name });
            id++;
        }

        // PUT api/<KinderGartenTicherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            var selectedTicher = _context.Tichers.Find(t => t.Id == id);
            selectedTicher.Name= name;  
        }

        // PUT api/<KinderGartenTicherController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Ticher.st)
        //{
        //    var selectedTicher = Tichers.Find(t => t.Id == id);
        //    selectedTicher.Staus = status;
        //}

        //// DELETE api/<KinderGartenTicherController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
