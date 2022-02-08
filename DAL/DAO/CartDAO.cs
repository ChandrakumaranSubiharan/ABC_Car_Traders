using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CartDAO : CartContext
    {
        public static List<orderDetail> GetOrderDetails(string text)
        {
            try
            {
                List<orderDetail> list = db.orderDetails.Where(x => x.client_name == text).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void AddOrderDetail(orderDetail OdrDts)
        {
            try
            {
                db.orderDetails.InsertOnSubmit(OdrDts);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void DeleteOrderDetail(orderDetail OdrDts)
        {
            try
            {
                orderDetail OdRDtS = db.orderDetails.First(x => x.Item_id == OdrDts.Item_id);
                db.orderDetails.DeleteOnSubmit(OdRDtS);
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
