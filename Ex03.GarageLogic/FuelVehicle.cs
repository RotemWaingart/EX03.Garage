// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelVehicle : Vehicle
    {
        private readonly string r_FuelType; // TO EDIT? change to enum?
        private float m_FuelLitersAmount;
        private readonly float r_FuelMaxAmount;
        private readonly List<string> r_FuelAllowedTypes = new List<string> { "Octan98", "Octan96", "Octan95", "Soler" };

        public FuelVehicle(VehicleType i_VehicleType) : base(i_VehicleType)
        {
            string fuelType = i_VehicleType.FuelTypeIfFule;
            float fuelMaxAmount = i_VehicleType.LitersMaxFuelIfFule;

            if (!r_FuelAllowedTypes.Contains(fuelType) || (fuelMaxAmount < 0))
            {
                throw new ArgumentException();
            }

            r_FuelType = fuelType;
            r_FuelMaxAmount = fuelMaxAmount;
        }

        public string FuelType
        {
            get { return r_FuelType; }
        }

        public float FuelMaxAmount
        {
            get { return r_FuelMaxAmount; }
        }

        public float FuelLitersAmount
        {
            get { return m_FuelLitersAmount; }
            private set { m_FuelLitersAmount = value; }
        }

        public void Refuel(string i_NewFuelType, float i_FuelToAdd)
        {
            float totalNewFuelAmount = this.FuelLitersAmount + i_FuelToAdd;

            if ((i_FuelToAdd < 0) || (totalNewFuelAmount > this.FuelMaxAmount))
            {
                throw new ValueOutOfRangeException(this.FuelMaxAmount);
            }

            this.FuelLitersAmount = totalNewFuelAmount;
        }

    }
}
