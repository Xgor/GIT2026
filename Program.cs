namespace GIT2026;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Sum(a, b);
     //   int c = a + b;
     //   Console.WriteLine(c);
        int[] numbers = Enumerable.Range(1, 100).ToArray();
        foreach (int number in numbers)
        {
            int x = number;
            Console.WriteLine(x);
        }
    }

    private static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
        
    }
}