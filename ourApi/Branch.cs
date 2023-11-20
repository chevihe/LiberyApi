namespace ourApi
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public Branch()
        {

        }
        public Branch(int breadId, string name, string addres, string phone)
        {
            BranchId = breadId;
            Name = name;
            Addres = addres;
            Phone = phone;
        }
    }
}
