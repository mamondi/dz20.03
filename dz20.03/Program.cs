class Program
{
    static void Main(string[] args)
    {

        Beverage coffeeWithMilk = new Milk(new Coffee());
        Console.WriteLine($"Напiй: {coffeeWithMilk.GetDescription()}");
        Console.WriteLine($"Цiна: ${coffeeWithMilk.Cost()}");
    }
}
