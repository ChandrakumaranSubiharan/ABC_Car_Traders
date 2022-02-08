using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class CarPartsBLL
    {
        public static void AddCarPart(sparepart CARPART)
        {
            CarPartDAO.AddCarPart(CARPART);
        }

        public static List<sparepart> GetCarParts()
        {
            return CarPartDAO.GetCarParts();
        }

        public static void UpdateCarPart(sparepart CARPART)
        {
            CarPartDAO.UpdateCarPart(CARPART);
        }

        public static void DeleteCarPart(sparepart CARPART)
        {
            CarPartDAO.DeleteCar(CARPART);
        }

        public static void UpdateCarPartQty(sparepart CARPART)
        {
            CarPartDAO.UpdateCarPartQty(CARPART);

        }
    }
}
