// TO DELETE
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Car : VehicleType
    {
        private string m_Color;
        private int m_NumOfDoors;
        private const int k_MinNumOfDoors = 2;
        private const int k_MaxNumOfDoors = 5;
        private readonly List<string> r_AllowedColors = new List<string> { "Yellow", "White", "Red", "Black" };
        private const int k_NumOfWheels = 5;
        private const int k_WheelMaxAirPressure = 31;
        private const string k_FuelTypeIfFule = "Octan95";
        private const float k_LitersMaxFuelIfFule = 45.0f;
        private const float k_BatteryMaxTimeIfElectric = 3.5f;

        public Car() : base(k_NumOfWheels, k_WheelMaxAirPressure, k_FuelTypeIfFule, k_LitersMaxFuelIfFule, k_BatteryMaxTimeIfElectric) { }

        public string Color 
        {
            get { return m_Color; }
            set 
            {
                if (!r_AllowedColors.Contains(value))
                {
                    throw new ArgumentException();
                }
                m_Color = value;
            }
        }

        public int NumOfDoors
        {
            get { return m_NumOfDoors; }
            set
            {
                if((value < k_MinNumOfDoors) || (value > k_MaxNumOfDoors))
                {
                    throw new ValueOutOfRangeException(k_MaxNumOfDoors, k_MinNumOfDoors);
                }
                m_NumOfDoors = value;
            }
        }
    }
}
