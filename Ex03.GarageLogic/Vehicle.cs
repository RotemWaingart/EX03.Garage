namespace Ex03.GarageLogic
{
    internal abstract class Vehicle
    {
        private readonly VehicleType r_VehicleType;
        private string m_ModelTitle;
        private string m_LicenseNumber;
        private float m_EnergyRemainingPercentage;
        private List<Wheel> m_Wheels = null;

        protected Vehicle(VehicleType i_VehicleType)
        {
            if (!VehiclesBuilder.ObjectsTypes.Contains(i_VehicleType.GetType()))
            {
                throw new FormatException();
            }
            this.r_VehicleType = i_VehicleType;
        }

        public VehicleType VehicleType
        {
            get { return r_VehicleType; }
        }

        public string ModelTitle
        {
            get { return m_ModelTitle; }
            set { m_ModelTitle = value; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
            set { m_LicenseNumber = value; }
        }

        public float EnergyRemainingPercentage
        {
            get { return m_EnergyRemainingPercentage; }
            protected set { m_EnergyRemainingPercentage = value; }
        }

        public List<Wheel> Wheels
        {
            get { return m_Wheels; }
            protected set { m_Wheels = value; }
        }

        public void InflateAllWheels(bool i_InfalteToMax, float i_AirToAdd = 0f)
        {
            if(m_Wheels != null)
            {
                foreach(Wheel wheel in m_Wheels)
                {
                    if(i_InfalteToMax)
                    {
                        wheel.InflateToMax();
                    }
                    else
                    {
                        wheel.Inflate(i_AirToAdd);
                    }
                }
            }
        }
    }

}