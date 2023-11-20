using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ourApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static int count = 3;
        private static List<Book> books = new List<Book> { new Book { BookId=1,Name="Dodi & odi" ,Status=true,Writer="Menocha",BranchId=1} ,
        new Book { BookId=2,Name="Lole ehemanti" ,Status=true,Writer="Libi Klain",BranchId=2} };

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get(string? name, int? status,int? branchId)
        {
            
            if (string.IsNullOrEmpty(name) && status == null&& branchId==null)
                return books;
            List<Book> b = new List<Book>();
            if (status == 1)//ספרים פנויים
            {
                b = books.FindAll(bo => bo.Status == true);
            }
            else if (status == 2)
            {
                b = books.FindAll(bo => bo.Status == true);
            }
            else
            {
                foreach (var book in books)//ספרים תפוסים
                {
                    b.Add(book);
                }
            }
            if(b.Count==0)
                return null;
            if (!(string.IsNullOrEmpty(name)))
            {
                b = b.FindAll(bo => bo.Name == name);
            }
            if (b.Count == 0)
                return null;
            
            if (branchId != null)
            {
                 b = b.FindAll(bo => bo.BranchId == branchId);
            }
            return b;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            foreach (var book in books)
            {
                if (book.BookId == id)
                    return book;
            }
            return null;
        }


        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            books.Add(book);
            books[books.Count - 1].BookId = count++;
        }

        // PUT api/<BookController>/5
        [HttpPut("status/{id}")]
        public void Put(int id, [FromBody] string status)
        {
            foreach (var book in books)
            {
                if (book.BookId == id)
                    book.Status = !(book.Status);
            }

        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book boo = books.Find(b => b.BookId == id);
            books.Remove(boo);
        }
    }
}
