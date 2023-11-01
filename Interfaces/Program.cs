namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interfaces");
    }
    /*
        A class that implements an interface must provide implementations for all the members declared
        in that interface. This is done by using the : symbol after the class name,
        followed by the name of the interface. (ctrl+. to auto implement).
     */
    public class Payment : IPayment
    {
        public DateTime DueDate { get ; set; }

        public void Pay(double valor)
        {
            throw new NotImplementedException();
        }
    }

    /*
        An interface is a fundamental concept that allows you to define a contract for a class.
        It specifies a set of methods, properties, events, or indexers
        that a class must implement if it chooses to implement that interface.
        Interfaces are a crucial part of C# because they enable polymorphism,
        allowing different classes to be treated as if they are of the same type when they implement the same interface.
     */
    public interface IPayment
    {
        public DateTime DueDate { get; set; }

        void Pay(double valor);
    }
}
