namespace StoreApp1.View
{
    public class EmployeeVM
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Dept { get; set; } = "";
        public string Address { get; set; } = "";
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PositionId { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
