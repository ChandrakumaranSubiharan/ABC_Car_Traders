using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class ClientDTO
    {
        public int clt_id { get; set; }
        public string clt_name { get; set; }
        public string clt_address { get; set; }
        public string clt_mobileNumber { get; set; }
        public DateTime? clt_registred_date { get; set; }
        public DateTime? clt_updated_date { get; set; }
    }
}
