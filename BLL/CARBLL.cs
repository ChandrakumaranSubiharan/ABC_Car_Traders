using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class CARBLL
    {
        public static bool AddCar(car CAR)
        {
            return CarDAO.AddCar(CAR);
        }

        public static List<CarDetailsDTO> GetCars()
        {
            return CarDAO.GetCars();
        }

        public static void UpdateCar(car CAR)
        {
            CarDAO.UpdateCar(CAR);
        }

        public static void UpdateCarAva(car CAR)
        {
            CarDAO.UpdateCarAva(CAR);
        }

        public static void DeleteCar(car CAR)
        {
            CarDAO.DeleteCar(CAR);
        }
    }
}
