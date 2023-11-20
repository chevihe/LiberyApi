using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public static int count = 2;
        private static List<Event> events = new List<Event> { new Event { Id =0, Title = "default event1",Start=DateTime.Now , End = DateTime.Now},
         new Event { Id = 1, Title = "default event2",Start=DateTime.Now ,End=DateTime.Now }
        , new Event { Id = 2, Title = "default event3",Start=DateTime.Now,End=DateTime.Now } };
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> GetAllEvents()
        {
            return events;
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            events.Add(new Event { Id = ++count, Title = newEvent.Title, Start = newEvent.Start,End=newEvent.End });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string title)
        {
            Event eve = events.Find(e => e.Id == id);
            eve.Title = title;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Event eve = events.Find(e => e.Id == id);
            events.Remove(eve);
            --count;
        }
    }
}
