using WiredBrainCoffee.Entities;
using WiredBrainCoffee.Repositories;

namespace WiredBrainCoffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepositoryWithRemove<Employee>();
            employeeRepository.Add(new Employee { FirstName= "Julia"});
            employeeRepository.Add(new Employee { FirstName= "Anna"});
            //employeeRepository.Remove();
            employeeRepository.Add(new Employee { FirstName= "Thomas"});
            employeeRepository.save();

            var OrganizationRepository = new GenericRepository<Organization>();
            OrganizationRepository.Add(new Organization { Name = "Pluralsight" });
            OrganizationRepository.Add(new Organization { Name = "GloboSat" });
            OrganizationRepository.save();

            Console.ReadLine();
        }
    }
}