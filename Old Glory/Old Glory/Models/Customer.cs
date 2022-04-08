namespace Old_Glory.Models
{
    public class Customer
    {
        internal readonly object Title;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
    }
}
