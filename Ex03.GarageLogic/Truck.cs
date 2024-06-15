// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Truck : VehicleType
    {
        private float m_CargoSize;
        private bool m_HaveDangerousCargo;
        private const int k_NumOfWheels = 12;
        private const int k_WheelMaxAirPressure = 28;
        private const string k_FuelTypeIfFule = "Soler";
        private const float k_LitersMaxFuelIfFule = 120.0f;

        public Truck() : base(k_NumOfWheels, k_WheelMaxAirPressure, k_FuelTypeIfFule, k_LitersMaxFuelIfFule) { }

        public float CargoSize
        {
            get { return m_CargoSize;}
            set 
            {
                if(value< 0.0f)
                {
                    throw new ArgumentException();
                }
                m_CargoSize = value;
            }
        }

        public bool HaveDangerousCargo
        {
            get { return m_HaveDangerousCargo; }
            set { m_HaveDangerousCargo = value; }
        }
    }
}
