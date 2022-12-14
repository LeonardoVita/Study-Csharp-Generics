namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            //var stack = new SimpleStackDouble();
            var stack = new SimpleStack<double>();
            //var stack = new Stack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Soma: {sum}");
        }

        private static void StackStrings()
        {
            //var stack = new SimpleStackString();
            var stack = new SimpleStack<string>();
            //var stack = new Stack<string>();
            stack.Push("Pluralsight");
            stack.Push("Café e muito bom");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}