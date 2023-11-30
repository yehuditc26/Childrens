using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Childrens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KinderGartenController : ControllerBase
    {
        public static List<KinderGarten> KinderGartens = new List<KinderGarten> { new KinderGarten { Id = 1, Name = "smallChildrens" }, new KinderGarten { Id = 2, Name = "MediumChikdrens" } };

        int id = KinderGartens.Last().Id + 1;


        // GET: api/<KinderGardenController>
        [HttpGet]
        public List<KinderGarten> Get()
        {
            return KinderGartens;
        }

        // GET api/<KinderGardenController>/5
        [HttpGet("{id}")]
        public KinderGarten Get(int id)
        {
            var selectedKinderG = KinderGartens.Find(k => k.Id == id);
            return selectedKinderG;
        }

        // POST api/<KinderGardenController>
        [HttpPost]
        public void Post([FromBody] string name)
        {
            KinderGartens.Add(new KinderGarten { Id = id, Name = name });
            id++;
        }

        // PUT api/<KinderGardenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            var selectedKinderG = KinderGartens.Find(k => k.Id == id);
            selectedKinderG.Name = name;
        }

        // DELETE api/<KinderGardenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var selectedKinderG = KinderGartens.Find(k => k.Id == id);
            KinderGartens.Remove(selectedKinderG);
        }
    }
}
