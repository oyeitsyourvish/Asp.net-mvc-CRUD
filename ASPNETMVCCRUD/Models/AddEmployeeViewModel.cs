namespace ASPNETMVCCRUD.Models
{
    public class AddEmployeeViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
