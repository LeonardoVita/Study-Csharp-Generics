using WiredBrainCoffee.Data;
using WiredBrainCoffee.Entities;
using WiredBrainCoffee.Repositories;

namespace WiredBrainCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);
            //GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            var OrganizationRepository = new ListRepository<Organization>();
            AddOrganizations(OrganizationRepository);
            //GetOrganizationById(OrganizationRepository);

            Console.ReadLine();
        }

        private static void WriteAllToConsole(IRepository<Employee> employeeRepository)
        {
            var employess = employeeRepository.GetAll();
            foreach (var employee in employess)
            {
                Console.WriteLine(employee.FirstName);
            }
        }

        private static void GetOrganizationById(ListRepository<Organization> organizationRepository)
        {
            var organization = organizationRepository.GetById(1);
            Console.WriteLine($"Organization with Id 0: {organization?.Name}");
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee?.FirstName}");
        }
        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.save();
        }
        private static void AddOrganizations(IRepository<Organization> OrganizationRepository)
        {
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "GloboSat" });
            OrganizationRepository.save();
        }
    }
}