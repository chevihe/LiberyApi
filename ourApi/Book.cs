namespace ourApi
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public bool Status { get; set; }
        public int BranchId { get; set; }
        public Book()
        {

        }
        public Book(int bookId, string name, string writer, bool status, int branchId)
        {
            BookId = bookId;
            Name = name;
            Writer = writer;
            Status = status;
            BranchId = branchId;
        }
    }
}
