using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class OrderBLL
    {
        public static List<order> GetOrder()
        {
            return OrderDAO.GetOrder();
        }
    }
}
