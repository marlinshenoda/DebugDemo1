



namespace DebugDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int value = Sum(2, 3);
            Console.WriteLine(value);   
        }

        private static int Sum(int v1, int v2)
        {
          return v1+ v2;
        }
    }
}
