namespace ourApi
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public int BookId { get; set; }

        public Partner()
        {

        }
        public Partner(int partnerId, string name, string phone, string addres, int bookId)
        {
            PartnerId = partnerId;
            Name = name;
            Addres = addres;
            Phone = phone;
            bookId = BookId;
        }
    }
}
