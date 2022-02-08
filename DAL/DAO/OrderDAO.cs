using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class OrderDAO : OrderContext
    {
        public static List<order> GetOrder()
        {
            return db.orders.ToList();
        }
    }

        //public static void GetOrder()
        //{
        //    try
        //    {
        //        var list = (from o in db.orders
        //                    join od in db.orderDetails on o.order_Details_id equals od.order_Details_id )
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
    }
