namespace ASPNETMVCCRUD.Models
{
    public class AddEmployeeViewModel
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public double Salary { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
