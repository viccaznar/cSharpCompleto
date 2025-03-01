    using System;
    using System.Globalization;
    using Course.Entites;
    using Course.Services;
    using Course.Interface;

    namespace Course
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Enter rental data: ");
                Console.Write("Car model: ");
                string model = Console.ReadLine();
                Console.Write("Pick up (dd/MM/yyyy hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Pick up (dd/MM/yyyy hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Enter price per hour: ");
                double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter price per day: ");
                double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));

                RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine("INVOICE:");
                Console.WriteLine(carRental.Invoice);
            }

        }
    }