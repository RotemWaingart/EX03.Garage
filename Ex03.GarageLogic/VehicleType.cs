// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class VehicleType
    {
        private readonly string r_FuelTypeIfFule;
        private readonly float r_LitersMaxFuelIfFule;
        private readonly float r_BatteryMaxTimeIfElectric;
        private readonly int r_NumOfWheels;
        private readonly int r_WheelMaxAirPressure;

        protected VehicleType(int i_NumOfWheels, int i_WheelMaxAirPressure, string i_FuelTypeIfFule = "", float i_LitersMaxFuelIfFule = 0f, float i_BatteryMaxTimeIfElectric = 0f)
        {
            this.r_NumOfWheels = i_NumOfWheels;
            this.r_WheelMaxAirPressure = i_WheelMaxAirPressure;
            this.r_FuelTypeIfFule = i_FuelTypeIfFule;
            this.r_LitersMaxFuelIfFule = i_LitersMaxFuelIfFule;
            this.r_BatteryMaxTimeIfElectric = i_BatteryMaxTimeIfElectric;
        }

        public string FuelTypeIfFule
        {
            get { return r_FuelTypeIfFule; }
        }

        public float LitersMaxFuelIfFule
        {
            get { return r_LitersMaxFuelIfFule; }
        }

        public float BatteryMaxTimeIfElectric
        {
            get { return r_BatteryMaxTimeIfElectric; }
        }
    }
}
