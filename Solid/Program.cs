using Solid;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var discount = new EletronicsDiscount();
        discount.Calculate(price:100M);
    }
}