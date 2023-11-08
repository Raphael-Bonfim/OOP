namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        var payment = new Payment();
        var subscription = new Subscription();

        var context = new DataContext<Person, Payment, Subscription>();

        context.Save(person);
    }

    /*
     Generics allow you to create classes, interfaces, methods, and delegates that work with data types as
     parameters, enabling you to create more flexible and reusable code. Generic classes, in particular,
     are classes that can work with different data types without specifying the exact data type at the time
     of declaration. This allows you to write code that is more type-safe and reusable.
     */
    public class DataContext<P, PA , S>
        //We can also use the "where" to make sure that the right Type is received
        where P : IPerson
        where PA : Payment
        where S : Subscription
    {
        public void Save(P entity)
        {

        }
        public void Save(PA entity)
        {

        }
        public void Save(S entity)
        {

        }
    }

    public interface IPerson { }

    public class Person : IPerson { }
    public class Payment { }
    public class Subscription { }
}
