using System;
namespace InterfaceExercise
{
    public interface IVehicle
	{
        public int NumberOfWheels { get; set; }
        public bool HasEngine { get; set; }
        public int NumberOfSeats { get; set; }
        public int MilesPerGallon { get; set; }
    }
}

