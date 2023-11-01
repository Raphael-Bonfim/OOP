namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
     /*
        Objects: An object is an instance of a class.
        It's a concrete realization of the class blueprint 
        and contains data (attributes) and methods (functions) that operate on that data.
     */
        var payment = new Payment(10.56, DateTime.Today);

        Console.WriteLine(payment.Amount);
        Console.WriteLine(payment.DueDate);
    }


    /*
        Classes: A class is a blueprint or template for creating objects. 
        It defines the structure and behavior of objects of that class.
        For example, a "Payment" class could define the properties and methods that all Payments share.
    */
    class Payment
    {
        //Constructor
        public Payment(double amount, DateTime duedate) { 
        
            Amount = amount;
            DueDate = duedate;
        }

        //Properties
        public DateTime DueDate { get; private set; }

        public double Amount { get; private set; }

        //Methods
        public void ProcessPayment() {}

    }
}
