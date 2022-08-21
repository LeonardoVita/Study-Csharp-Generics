namespace Generics
{
    public class SimpleStack<T>
    {
        private readonly T[] _item;
        private int _currentIndex = -1;

        public SimpleStack() => _item = new T[10];

        public int Count => _currentIndex + 1;

        public void Push(T item) => _item[++_currentIndex] = item;

        public T Pop() => _item[_currentIndex--];
    }
    public class SimpleStackObject
    {
        private readonly object[] _item;
        private int _currentIndex = -1;

        public SimpleStackObject() => _item = new object[10];

        public int Count => _currentIndex + 1;

        public void Push(object item) => _item[++_currentIndex] = item;

        public object Pop() => _item[_currentIndex--];
    }

    public class SimpleStackDouble
    {
        private readonly double[] _item;
        private int _currentIndex = -1;

        public SimpleStackDouble() => _item = new double[10];

        public int Count => _currentIndex + 1;

        public void Push(double item) => _item[++_currentIndex] = item;

        public double Pop() => _item[_currentIndex--];
    }

    public class SimpleStackString
    {
        private readonly string[] _item;
        private int _currentIndex = -1;

        public SimpleStackString() => _item = new string[10];

        public int Count => _currentIndex + 1;

        public void Push(string item) => _item[++_currentIndex] = item;

        public string Pop() => _item[_currentIndex--];
    }
}