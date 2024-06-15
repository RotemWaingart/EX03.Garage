// TO DELETE?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class GarageManagment
    {
        private Dictionary<string, VehicleInGarage> m_VehiclesInGarage = new Dictionary<string, VehicleInGarage>();

        public bool ExistInGarage(string i_VehicleLicenseNumber)
        {
            return m_VehiclesInGarage.ContainsKey(i_VehicleLicenseNumber);
        }

        public void ReEnterToGarage(string i_VehicleLicenseNumber)  // TO EDIT? without hard coded
        {
            ChangeVehicleStatus(i_VehicleLicenseNumber, "Repair");
        }


        public void NewEnterToGarage(VehicleInGarage i_NewVehicleInGarage)
        {
            string vehicleLicenseNumber = i_NewVehicleInGarage.Vehicle.LicenseNumber;

            if (!ExistInGarage(vehicleLicenseNumber))
            {
                throw new ArgumentException();
            }

            m_VehiclesInGarage.Add(vehicleLicenseNumber, i_NewVehicleInGarage);
        }

        public List<VehicleInGarage> GetVehiclesInGarage(List<string> i_FiltersByStatus)
        {
            List<VehicleInGarage> vehicleInGaragesByFilters = new List<VehicleInGarage>();

            if(m_VehiclesInGarage.Count > 0)
            {
                foreach (string filter in i_FiltersByStatus)
                {
                    if (!m_VehiclesInGarage.First().Value.CarsStatuses.Contains(filter)) // status filter in filteres list parameter isn't a valid status
                    {
                        throw new ArgumentException();
                    }
                }

                foreach(KeyValuePair<string, VehicleInGarage> vehicleInGarage in m_VehiclesInGarage)
                {
                    if(i_FiltersByStatus.Contains(vehicleInGarage.Value.Status))
                    {
                        vehicleInGaragesByFilters.Add(vehicleInGarage.Value);
                    }
                }
            }
            return vehicleInGaragesByFilters;
        }

        public void ChangeVehicleStatus(string i_VehicleLicenseNumber, string i_NewVehicleStatus) // TO EDIT? without hard coded
        {
            if (!ExistInGarage(i_VehicleLicenseNumber))
            {
                throw new ArgumentException();
            }

            if (!m_VehiclesInGarage[i_VehicleLicenseNumber].CarsStatuses.Contains(i_NewVehicleStatus))
            {
                throw new ArgumentException();
            }

            switch(i_NewVehicleStatus)
            {
                case "Repair":
                    m_VehiclesInGarage[i_VehicleLicenseNumber].SetStatusToRepair();
                    break;
                case "Fixed":
                    m_VehiclesInGarage[i_VehicleLicenseNumber].SetStatusToFixed();
                    break;
                case "Paid":
                    m_VehiclesInGarage[i_VehicleLicenseNumber].SetStatusToPaid();
                    break;
            }
        }

        public void InflateWheelsToMax(string i_VehicleLicenseNumber)
        {
            bool infalteToMax = true;

            if (!ExistInGarage(i_VehicleLicenseNumber))
            {
                throw new ArgumentException();
            }
            m_VehiclesInGarage[i_VehicleLicenseNumber].Vehicle.InflateAllWheels(infalteToMax);
        }


    }
}
