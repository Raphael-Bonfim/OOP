namespace AbstractClasses;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract Classes");
    }

    /*
        An abstract class is a class that cannot be instantiated on its own but serves as a blueprint
        for other classes. Abstract classes are used to define a common structure, behavior, and a set of methods
        that derived classes must implement.
        They are a crucial part of object-oriented programming and can help create a hierarchy
        of related classes that share common features. 
     */
    public abstract class Payment : IPayment
    {
        public DateTime DueDate { get; set; }

        public virtual void Pay(double valor)
        {
            throw new NotImplementedException();
        }
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay(double valor)
        {
            base.Pay(valor);
        }
    }

    public class TransferencePayment : Payment
    {
        public override void Pay(double valor)
        {
            base.Pay(valor);
        }
    }

    public class ApplePayPayment : Payment
    {
        public override void Pay(double valor)
        {
            base.Pay(valor);
        }
    }

    public interface IPayment
    {
        public DateTime DueDate { get; set; }

        void Pay(double valor);
    }
}
