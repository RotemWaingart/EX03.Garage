// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricVehicle : Vehicle
    {
        private float m_BatteryRemainingTime = 0;
        private readonly float r_BatteryMaxTime;

        public ElectricVehicle(VehicleType i_VehicleType) : base(i_VehicleType)
        {
            r_BatteryMaxTime = i_VehicleType.BatteryMaxTimeIfElectric;
        }

        public float BatteryRemainingTime
        {
            get { return m_BatteryRemainingTime;}
            private set { m_BatteryRemainingTime = value;}
        }

        public float BatteryMaxTime
        {
            get { return r_BatteryMaxTime; }
        }

        public void ChargeBattery(float i_BatteryTimeToAdd) 
        {
            float totalNewBatteryTime = this.BatteryRemainingTime + i_BatteryTimeToAdd;
            if((totalNewBatteryTime < 0) || (totalNewBatteryTime > r_BatteryMaxTime))
            {
                throw new ValueOutOfRangeException(r_BatteryMaxTime);
            }

            this.BatteryRemainingTime= totalNewBatteryTime;
        }


    }
}
