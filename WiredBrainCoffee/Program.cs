using WiredBrainCoffee.Entities;
using WiredBrainCoffee.Repositories;

namespace WiredBrainCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new ListRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var OrganizationRepository = new ListRepository<Organization>();
            AddOrganizations(OrganizationRepository);

            Console.ReadLine();
        }

        private static void GetEmployeeById(ListRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.FirstName}");
        }

        private static void AddEmployees(ListRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.save();
        }

        private static void AddOrganizations(ListRepository<Organization> OrganizationRepository)
        {
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "GloboSat" });
            OrganizationRepository.save();
        }
    }
}