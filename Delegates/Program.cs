namespace Delegates;
/*
    A delegate is a type that represents a reference to a method. Delegates are often used to create
    callback mechanisms, event handling, and defining method signatures that can be assigned to other methods 
    at runtime. They provide a way to encapsulate a method, pass it as an argument to other methods,
    and call it indirectly.
 */
class Program
{
    static void MakePayment(double value)
    {
        Console.WriteLine($"The value: $ {value} was paid out.");
    }

    static void Main(string[] args)
    {
        var pay = new Payment.Pay(MakePayment);

        pay(25.30);
    }

    public class Payment
    {
        public delegate void Pay(double value);
    }
}
