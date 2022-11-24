using Class_Library;

namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Ferid",
                Surname = "Quliyev",
                Salary = 500
            };
            Department.AddEmployee(employee);
        }
    }
}