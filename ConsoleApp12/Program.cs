using System;

class Parent
{
    protected int Pole1;
    protected double Pole2;

    public Parent(int pole1, double pole2)
    {
        Pole1 = pole1;
        Pole2 = pole2;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Кількість пасажирів: {Pole1},Вартість квитка: {Pole2}");
    }

    public virtual double Method()
    {
        return Pole1 * Pole2;
    }
}

class Child1 : Parent
{
    private double Pole3;

    public Child1(int pole1, double pole2, double pole3) : base(pole1, pole2)
    {
        Pole3 = pole3;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Середня швидкість: {Pole3}");
    }

    public override double Method()
    {
        double parentMethodResult = base.Method();
        return parentMethodResult + Pole1 * Pole3 * 0.05;
    }
}

class Child2 : Parent
{
    private double Pole4;

    public Child2(int pole1, double pole2, double pole4) : base(pole1, pole2)
    {
        Pole4 = pole4;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Відстань в км: {Pole4}");
    }

    public override double Method()
    {
        double parentMethodResult = base.Method();
        return parentMethodResult - Pole1 * Pole4 * 0.01;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Parent parent = new Parent(10, 5.5);
        Child1 child1 = new Child1(20, 7.5, 50);
        Child2 child2 = new Child2(30, 6.5, 100.5);

        Console.WriteLine("звичайний:");
        parent.Print();
        Console.WriteLine($"Виручка: {parent.Method()}");

        Console.WriteLine("\nекспрес:");
        child1.Print();
        Console.WriteLine($"Виручка: {child1.Method()}");

        Console.WriteLine("\nприміський:");
        child2.Print();
        Console.WriteLine($"Виручка: {child2.Method()}");
    }
}
