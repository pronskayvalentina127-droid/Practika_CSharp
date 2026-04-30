namespace EmployeeApp
{
    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public Employee(string name, string pos)
        {
            FullName = name;
            Position = pos;
        }
    }
}