namespace WiredBrainCoffee.Entities
{
    public class Employee : EntityBase
    {
        //must be parameterless class to use new() constraint in generic class
        //this dosent work
        //public Employee(string? firstName)
        //{
        //    FirstName = firstName;
        //}

        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";
    }
}
