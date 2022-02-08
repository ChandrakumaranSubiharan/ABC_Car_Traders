using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class CarDetailsDTO
    {
        public int CarID { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string Availability { get; set; }
        public string Type { get; set; }
        public float price { get; set; }
        public string ImagePath { get; set; }
        public DateTime? Added_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
    }
}
