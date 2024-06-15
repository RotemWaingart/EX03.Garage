// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Motorcycle : VehicleType
    {
        private string m_License;
        private int m_EngineSize;
        private readonly List<string> r_LicenseAllowedTypes = new List<string> { "A", "A1", "AA", "B1" };
        private const int k_NumOfWheels = 2;
        private const int k_WheelMaxAirPressure = 33;
        private const string k_FuelTypeIfFule = "Octan98";
        private const float k_LitersMaxFuelIfFule = 5.5f;
        private const float k_BatteryMaxTimeIfElectric = 2.5f;

        public Motorcycle() : base(k_NumOfWheels, k_WheelMaxAirPressure, k_FuelTypeIfFule, k_LitersMaxFuelIfFule, k_BatteryMaxTimeIfElectric) { }

        public string License
        {
            get { return m_License; }
            set
            {
                if (!r_LicenseAllowedTypes.Contains(value))
                {
                    throw new ArgumentException();
                }
                m_License = value;
            }
        }

        public int EngineSize
        {
            get { return m_EngineSize; }
            set { m_EngineSize = value; }
        }
    }
}
