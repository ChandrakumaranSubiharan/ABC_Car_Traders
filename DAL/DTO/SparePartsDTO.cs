using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SparePartsDTO
    {
        public int partID { get; set; }
        public string Name { get; set; }
        public string Menufectur { get; set; }
        public string Warrenty { get; set; }
        public int Price { get; set; }
        public int quantity { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? UpdatedAdded { get; set; }
    }
}
