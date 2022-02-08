using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class CartDTO : order
    {
        public int Quantity { get; set; }
        public int PricePerUnit { get; set; }
        public int totalAmount { get; set; }
        public string paymentType  { get; set; }

    }
}
