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
            AddManager(employeeRepository);
            //GetEmployeeById(employeeRepository);
            WriteAllToConsole(employeeRepository);

            //contravariance for generic Writing method (in T)
            //IWriteRepository<Manager> repo = new SqlRepository<Employee>(new StorageAppDbContext());

            var OrganizationRepository = new ListRepository<Organization>();
            AddOrganizations(OrganizationRepository);
            WriteAllToConsole(OrganizationRepository);
            //GetOrganizationById(OrganizationRepository);

            //covariance for generic reading method (out T)
            //IReadRepository<IEntity> repo = new SqlRepository<Employee>(new StorageAppDbContext());

            Console.ReadLine();
        }

        private static void AddManager(IWriteRepository<Manager> ManagerRepository)
        {
            //this nos work becase add methos only accepts Managers
            //employeeRepository.Add(new Employee());
            ManagerRepository.Add(new Manager { FirstName = "Sarah" });
            ManagerRepository.Add(new Manager { FirstName = "Henry" });
            ManagerRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEntity> Repository)
        {
            var items = Repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
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
            employeeRepository.Save();
        }
        private static void AddOrganizations(IRepository<Organization> OrganizationRepository)
        {
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "GloboSat" });
            OrganizationRepository.Save();
        }
    }
}