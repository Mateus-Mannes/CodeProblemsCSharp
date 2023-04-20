public static class NumberSwapper
{
    public static void Run(int a, int b)
    {
        Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);
        Swap(ref a, ref b);
        Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
    }

    public static void Swap(ref int a, ref int b)
    {
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }

    // swap using the diff
    public static void Swap2(ref int a, ref int b)
    {
        a = a - b;
        b = a + b;
        a = b - a;
    }
}