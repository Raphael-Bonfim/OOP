using System.Collections;
using System.Collections.Generic;

namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        IList<Payment> payments = new List<Payment>();

        payments.Add(new Payment(1));
        payments.Add(new Payment(2));
        payments.Add(new Payment(3));
        payments.Add(new Payment(4));
        payments.Add(new Payment(5));

        foreach (var item in payments) 
        { 
            Console.WriteLine(item.Id);
        }

        var payment = payments.First(x => x.Id == 3);

        payments.Remove(payment);

        foreach (var item in payments)
        {
            Console.WriteLine(item.Id);
        }

        var exists = payments.Any(x => x.Id == 3);
        Console.WriteLine(exists);
    }

    public class Payment
    {
        public int Id { get; set; }
        public Payment(int id)
        {
            Id = id;
        }
    }
}
