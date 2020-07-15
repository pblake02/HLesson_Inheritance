 using System;

namespace HLesson_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from HLesson_Inheritance!");

            //Declare and call classes here...added by pb 07142020
            Car car1 = new Car(true, true, 4, 6, "red", 4, 2016);
            car1.Start();
            car1.Stop();
            car1.Start();
            car1.Stop();
            car1.Start();
            car1.Stop();            
            car1.Stop();
            car1.GetVehicleDetails();

            //Vehicle vehicle2 = new Vehicle(2, 6, "red", 4);
            //vehicle2.Start();
            //vehicle2.Stop();
            //vehicle2.GetVehicleDetails();

            //Vehicle vehicle2 = new Vehicle(2, 6, "red", 4);
            //vehicle2.Start();
            //vehicle2.Stop();
            //vehicle2.GetVehicleDetails();

            Boat boat1 = new Boat(true, false, "yacht", 6, 12, "white", 0, 2019);
            boat1.Start();
            boat1.Stop();
            boat1.Start();            
            boat1.Start();
            boat1.Stop();
            boat1.Start();
            boat1.Stop();
            boat1.Stop();
            boat1.Stop();
            boat1.Start();
            boat1.Stop();
            boat1.GetVehicleDetails();

            Plane plane1 = new Plane(true, 4, 80, 4, 150, "orange", 16, 2020);
            plane1.Start();
            plane1.Stop();
            plane1.Stop();
            plane1.Stop();
            plane1.Stop();
            plane1.Start();
            plane1.Stop();
            plane1.Start();
            plane1.Stop();
            plane1.Start();
            plane1.Start();
            plane1.GetVehicleDetails();
        }
    }
}
