namespace UpcastAndDowncast;

class Program
{
    static void Main(string[] args)
    {
        /*
         Upcasting is the process of casting an object from a derived (subclass) type to a base (superclass)
         type. This is considered a safe operation, as it involves moving from a more specific type to a more
         general type. Upcasting is done implicitly and does not require any explicit casting syntax.
        It allows you to treat an object of a derived class as if it were an object of the base class.
        */

        var personUpcast = new Person();

        personUpcast = new Personal(); //Upcasting
        personUpcast = new Corporate(); //Upcasting


        /*
         Downcasting is the opposite of upcasting. It involves casting an object from a base (superclass) 
         type to a derived (subclass) type. This operation is considered potentially unsafe because the
         object might not actually be an instance of the derived class.
         To perform downcasting, you need to use an explicit cast (casting syntax), and it may throw 
         an exception at runtime if the object is not of the expected derived type.
        */

        var personDowncast = new Person();
        var personalDowncast = new Personal();

        personalDowncast = (Personal)personDowncast; //Downcasting
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Personal : Person 
    {
        public string CPF { get; set; }
    }

    public class Corporate : Person
    {
        public string CNPJ { get; set; }
    }
}
