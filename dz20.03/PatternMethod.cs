public abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double Cost();
}

// Конкретний напій
public class Coffee : Beverage
{
    public override string GetDescription()
    {
        return "Кава";
    }

    public override double Cost()
    {
        return 1.5;
    }
}

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;

    public CondimentDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription();
    }

    public override double Cost()
    {
        return beverage.Cost();
    }
}


//Не впевнений, чи можна це рахувати за проксі, але тим не менш
public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Молоко";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.5;
    }
}
