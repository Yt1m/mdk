using System;

class AEROFLOT
{
    public string Destination { get; set; }
    public int FlightNumber { get; set; }
    public string AircraftType { get; set; }
}

class Program
{
    static void Main(string[] args)
    {

        AEROFLOT[] flights = new AEROFLOT[7];

        
        Console.WriteLine("Введите данные о рейсах:");
        for (int i = 0; i < flights.Length; i++)
        {
            flights[i] = new AEROFLOT();

            Console.WriteLine("Пункт назначения рейса:");
            flights[i].Destination = Console.ReadLine();

            Console.WriteLine("Номер рейса:");
            flights[i].FlightNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Тип самолета:");
            flights[i].AircraftType = Console.ReadLine();
        }

        Array.Sort(flights, (x, y) => x.Destination.CompareTo(y.Destination));


        Console.WriteLine("Введите тип самолета для поиска:");
        string searchAircraftType = Console.ReadLine();

        bool found = false;
        Console.WriteLine($"Рейсы, обслуживаемые самолетом типа {searchAircraftType}:");
        foreach (var flight in flights)
        {
            if (flight.AircraftType == searchAircraftType)
            {
                Console.WriteLine($"Пункт назначения: {flight.Destination}, Номер рейса: {flight.FlightNumber}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Рейсы с указанным типом самолета не найдены.");
        }
    }
}
