using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        // GET: api/<PartnerController>
        private static int id = 4;
        private static List<Partner> Partners = new List<Partner> { new Partner
        {PartnerId=0,Addres="Bney Brack",Name= "shloimi herman" ,Phone="035768945",BookId=0} ,
        new Partner{PartnerId=1,Addres="Elad",Name= "rina coen" ,Phone="035768941",BookId=2},
        new Partner{PartnerId=2,Addres="Beyt Shemesh",Name= "sari levin" ,Phone="035768942", BookId = 3},
        new Partner{PartnerId=3,Addres="Netania",Name= "yosef davidoviz" ,Phone="035768943",BookId=1}};
        // GET: api/<BreadController>
        [HttpGet]
        public IEnumerable<Partner> Get(int? bookId)
        {
            if (bookId == null) return Partners;
            return Partners.FindAll(p => p.BookId == bookId);
        }

        // GET api/<BreadController>/5
        [HttpGet("{id}")]
        public Partner Get(int id)
        {
            Partner pr = Partners.Find(p => p.PartnerId == id);
            return pr;
        }

        // POST api/<BreadController>
        [HttpPost]
        public void Post([FromBody] Partner p)
        {
            Partners.Add(new Partner { PartnerId = id++, Addres = p.Addres, Name = p.Name, Phone = p.Phone });
        }

        // PUT api/<BreadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Partner p)
        {
            Partner partner= Partners.Find(pr => pr.PartnerId == id);
            partner.Addres = p.Addres;
            partner.Phone = p.Phone;
            partner.Name = p.Name;
            partner.BookId = p.BookId;
        }

        // DELETE api/<BreadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Partner partner = Partners.Find(p => p.PartnerId == id);
            Partners.Remove(partner);
        }
    }
}
