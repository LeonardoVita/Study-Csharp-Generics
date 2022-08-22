using WiredBrainCoffee.Entities;
using WiredBrainCoffee.Repositories;

namespace WiredBrainCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee { FirstName= "Julia"});
            employeeRepository.Add(new Employee { FirstName= "Anna"});
            employeeRepository.Add(new Employee { FirstName= "Thomas"});
            employeeRepository.save();

            Console.ReadLine();
        }
    }
}