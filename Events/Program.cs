namespace Events;

class Program
{
    static void Main(string[] args)
    {
        var room = new Room(3);
        room.RoomSoldOutEvent += OnRoomSoldOut;

        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
    }

    static void OnRoomSoldOut(object sender, EventArgs e)
    {
        Console.WriteLine("Crowded room.");
    }
}

public class Room
{
    public Room(int seats)
    {
        Seats = seats;
        seatsInUse = 0;
    }

    private int seatsInUse = 0;
    public int Seats { get; set; }

    public void ReserveSeat()
    {
        seatsInUse++;

        if (seatsInUse >= Seats)
        {
            OnRoomSoldOut(EventArgs.Empty);
        }
        else
        {
            Console.WriteLine("Reserved Seat");
        }
    }

    /*
     Events provide a way to implement the observer design pattern, allowing one object (the publisher)
     to notify multiple other objects (subscribers) when a particular action or event occurs.
     Events are commonly used in graphical user interfaces (GUI), asynchronous programming, and various other
     scenarios where you want one part of your program to react to changes or actions in another part.
     */
    public event EventHandler RoomSoldOutEvent;

    protected virtual void OnRoomSoldOut(EventArgs e)
    {
        EventHandler handler = RoomSoldOutEvent;

        handler?.Invoke(this, e);
    }
}