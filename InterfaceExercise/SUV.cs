using System;
namespace InterfaceExercise
{
	public class SUV: IVehicle, ICompany
	{
        public int NumberOfWheels { get; set; } = 4;
        public bool HasEngine { get; set; } = true;
        public int NumberOfSeats { get; set; } = 5;
        public int MilesPerGallon { get; set; } = 40;

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public bool HasCargo { get; set; }
        public bool HasOffRoading { get; set; }

        public void SUVDesciption()
		{
            Console.WriteLine($"For this particular vehicle the logo is {Logo}, the slogan is {Slogan}. Like it's competitors, it has {NumberOfWheels} number of wheels,and has an impressive range of {MilesPerGallon} MPG.");
            Console.WriteLine("Other notable facts are:");
            Console.WriteLine($"Has an engine: {HasEngine}");
            Console.WriteLine($"Has {NumberOfSeats} seats");
            Console.WriteLine($"Has a trunk: {HasCargo}");
            Console.WriteLine($"It can be raced: {HasOffRoading}");
        }
    }
}

