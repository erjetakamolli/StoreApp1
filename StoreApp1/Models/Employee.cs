namespace StoreApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Dept { get; set; } = "";
        public string Address { get; set; } = "";
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Position { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
