namespace ASPNETMVCCRUD.Models.Domains
{
    public class Employee
    {
        //Guid is it take unique identifier.
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Department {  get; set; }


    }
}
