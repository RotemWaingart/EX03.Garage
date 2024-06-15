// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Wheel
    {
        private string m_Manufacturer;
        private float m_CurrentAirPressure;
        private readonly float r_MaxAirPressure;

        public Wheel(float i_MaxAirPressure)
        {
            if (i_MaxAirPressure < 0)
            {
                throw new ArgumentException();
            }

            r_MaxAirPressure = i_MaxAirPressure;
        }

        public string Manufacturer
        { 
            get { return m_Manufacturer; } 
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure;}
            private set { m_CurrentAirPressure = value;}
        }

        public float MaxAirPressure
        {
            get { return r_MaxAirPressure; }
        }

        public void Inflate(float i_AirToAdd)
        {
            float totalNewAirPressure = this.CurrentAirPressure + i_AirToAdd;

            if ((i_AirToAdd < 0) || (totalNewAirPressure > this.MaxAirPressure))
            {
                throw new ValueOutOfRangeException(this.MaxAirPressure);
            }

            this.CurrentAirPressure = totalNewAirPressure;
        }

        public void InflateToMax()
        {
            Inflate(MaxAirPressure - CurrentAirPressure);
        }
    }
}
