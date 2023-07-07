using System;
namespace InterfaceExercise
{
	public class Truck: IVehicle, ICompany
	{
        public int NumberOfWheels { get; set; } = 4;
        public bool HasEngine { get; set; } = true;
        public int NumberOfSeats { get; set; } = 5;
        public int MilesPerGallon { get; set; } = 40;

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public bool HasBed { get; set; }
		public bool HasTowingCapability { get; set; }

		public void TruckDescription()
		{
            Console.WriteLine($"For this particular vehicle the logo is {Logo}, the slogan is {Slogan}. Like it's competitors, it has {NumberOfWheels} number of wheels, but unlike it's counterparts has a low range of {MilesPerGallon} MPG.");
            Console.WriteLine("Other notable facts are:");
            Console.WriteLine($"Has an engine: {HasEngine}");
            Console.WriteLine($"Has {NumberOfSeats} seats");
            Console.WriteLine($"Has a trunk: {HasBed}");
            Console.WriteLine($"It can be raced: {HasTowingCapability}");
        }
    }
}

