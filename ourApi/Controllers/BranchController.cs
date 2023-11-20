using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private static int id = 4;
        private static List<Branch> branchs = new List<Branch> { new Branch
        {BranchId=0,Addres="Bney Brack",Name= "Books-Bney Brack" ,Phone="035768945"} ,
        new Branch{BranchId=1,Addres="Elad",Name= "Books-Elad" ,Phone="035768941"},
        new Branch{BranchId=2,Addres="Beyt Shemesh",Name= "Books-Beyt Shemesh" ,Phone="035768942"},
        new Branch{BranchId=3,Addres="Netania",Name= "Books-Netania" ,Phone="035768943"}};
        // GET: api/<BreadController>
        [HttpGet]
        public IEnumerable<Branch> Get()
        {
            return branchs;
        }

        // GET api/<BreadController>/5
        [HttpGet("{id}")]
        public Branch Get(int id)
        {
            Branch br = branchs.Find(b => b.BranchId == id);
            return br;
        }

        // POST api/<BreadController>
        [HttpPost]
        public void Post([FromBody] Branch b)
        {
            branchs.Add(new Branch { BranchId = id++, Addres = b.Addres, Name = b.Name, Phone = b.Phone });
        }

        // PUT api/<BreadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Branch b)
        {
            Branch br = branchs.Find(bra => bra.BranchId == id);
            br.Addres = b.Addres;
            br.Phone = b.Phone;
            br.Name = b.Name;
        }

        // DELETE api/<BreadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Branch br = branchs.Find(b => b.BranchId == id);
            branchs.Remove(br);
        }
    }
}
