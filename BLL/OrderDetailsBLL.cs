using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class OrderDetailsBLL
    {
        public static List<orderDetail> GetOrderDetails (string text)
        {
            return CartDAO.GetOrderDetails(text);
        }

        public static void AddOrderDetail(orderDetail OdrDts)
        {
            CartDAO.AddOrderDetail(OdrDts);
        }

        public static void DeleteOrderDetail(orderDetail OdrDts)
        {
            CartDAO.DeleteOrderDetail(OdrDts);
        }
    }
}
