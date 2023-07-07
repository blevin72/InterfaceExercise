using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany-DONE!

            //Create 3 classes called Car , Truck , & SUV--DONE!

            //In your IVehicle--DONE!

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany--DONE!

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes--DONE!

            /*Create 2 members that are specific to each class--DONE!
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.--DONE!
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            car1.NumberOfWheels = 4;
            car1.HasEngine = true;
            car1.NumberOfSeats = 5;
            car1.MilesPerGallon = 40;
            car1.Logo = "Model of a Jaguar";
            car1.Slogan = "Great, Space, Pace";
            car1.HasTrunk = true;
            car1.IsRaceable = true;

            truck1.NumberOfWheels = 4;
            truck1.HasEngine = true;
            truck1.NumberOfSeats = 5;
            truck1.MilesPerGallon = 20;
            truck1.Logo = "Ram Horns";
            truck1.Slogan = "Guts. Glory. Ram";
            truck1.HasBed = true;
            truck1.HasTowingCapability = true;

            suv1.NumberOfWheels = 4;
            suv1.HasEngine = true;
            suv1.NumberOfSeats = 7;
            suv1.MilesPerGallon = 30;
            suv1.Logo = "V on top of the W";
            suv1.Slogan = "Das Auto";
            suv1.HasCargo = true;
            suv1.HasOffRoading = true;

            car1.CarDescription();
            Console.WriteLine();
            truck1.TruckDescription();
            Console.WriteLine();
            suv1.SUVDesciption();
        }
    }
}
