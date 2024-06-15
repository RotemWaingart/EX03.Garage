using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class VehicleInGarage
    {
        private readonly Vehicle r_Vehicle;
        private string m_OwnerName;
        private string m_OwnerPhoneNum;
        private string m_Status;
        private readonly List<string> r_CarsStatuses = new List<string> { "Repair", "Fixed", "Paid" };

        public VehicleInGarage(Vehicle i_Vehicle)
        {
            r_Vehicle = i_Vehicle;
            this.Status = r_CarsStatuses.FirstOrDefault(); // "Repair" status which is the default for new vehicle in garage
        }

        public Vehicle Vehicle
        {
            get { return r_Vehicle; }
        }

        public string OwnerName
        {
            get { return m_OwnerName; }
            set { m_OwnerName = value; }
        }

        public string OwnerPhoneNum
        {
            get { return m_OwnerPhoneNum;}
            set { m_OwnerPhoneNum = value;}
        }

        public string Status
        {
            get { return m_Status; }
            private set
            {
                if (!r_CarsStatuses.Contains(value))
                {
                    throw new ArgumentException();
                }
                m_Status = value;
            }
        }

        public List<string> CarsStatuses
        {
            get { return r_CarsStatuses;}
        }

        public void SetStatusToRepair() // TO EDIT? all of the following 3 methods
        {
            Status = "Repair";
        }

        public void SetStatusToFixed()
        {
            Status = "Fixed";
        }

        public void SetStatusToPaid()
        {
            Status = "Paid";
        }


    }
}
