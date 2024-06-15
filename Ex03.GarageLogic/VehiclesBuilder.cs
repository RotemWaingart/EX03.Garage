// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class VehiclesBuilder
    {
        private static readonly List<Type> r_ObjectsTypes = new List<Type> { typeof(Motorcycle), typeof(Car), typeof(Truck) }; // TO EDIT? change from static to non-static

        public static List<Type> ObjectsTypes
        { 
            get { return r_ObjectsTypes; }
        }

        public static FuelVehicle GenerateFuelMotorcycle()
        {
            return new FuelVehicle(new Motorcycle());
        }

        public static ElectricVehicle GenerateElectricMotorcycle()
        {
            return new ElectricVehicle(new Motorcycle());
        }

        public static FuelVehicle GenerateFuelCar()
        {
            return new FuelVehicle(new Car());
        }

        public static ElectricVehicle GenerateElectricCar()
        {
            return new ElectricVehicle(new Car());
        }

        public static FuelVehicle GenerateTruck()
        {
            return new FuelVehicle(new Truck());
        }
    }
}
