namespace ComparingObjects;

class Program
{
    static void Main(string[] args)
    {
        var personA = new Person(1,"Anatoly");
        var personB = new Person(1,"Anatoly");
        
        Console.WriteLine(personA.Equals(personB));
    }

    /*
     The IEquatable<T> interface in C# is a generic interface that allows you to define a custom method
     for comparing objects for value equality. It is particularly useful when you want to compare instances
     of a specific type for equality without boxing or casting, and it provides a performance benefit
     in scenarios like working with collections or dictionaries.
     */

    public class Person : IEquatable<Person>
    {
        public Person(int id, string name)
        {
            Name = name;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }


        /*
         Define the Equals method as required by the interface. This method should accept an argument of the same
        type as your class (of type T) and return a Boolean indicating whether the current object is equal to
        the provided object.
         */

        public bool Equals(Person? other)
        {
            return Id == other.Id && Name == other.Name;
        }
    }
}
