using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public int NumberOfWheels { get; set; } = 4;//done
		public bool HasEngine { get; set; } = true;//done
		public int NumberOfSeats { get; set; } = 5;//done
		public int MilesPerGallon { get; set; } = 40;//done

        public string Logo { get; set; } //done
        public string Slogan { get; set; } //done

        public bool HasTrunk { get; set; }//done
		public bool IsRaceable { get; set; }

		public void CarDescription()
		{
			Console.WriteLine($"For this particular vehicle the logo is {Logo}, the slogan is {Slogan}. Like it's competitors, it has {NumberOfWheels} number of wheels, but unlike it's counterparts has an impressive range of {MilesPerGallon} MPG.");
			Console.WriteLine("Other notable facts are:");
			Console.WriteLine($"Has an engine: {HasEngine}");
			Console.WriteLine($"Has {NumberOfSeats} seats");
			Console.WriteLine($"Has a trunk: {HasTrunk}");
			Console.WriteLine($"It can be raced: {IsRaceable}");
		}
	}		
}

