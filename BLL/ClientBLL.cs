using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class ClientBLL
    {
        public static void AddClient(client CLT)
        {
            ClientDAO.AddClient(CLT);
        }

        public static List<client>GetClients()
        {
            return ClientDAO.GetClients();
        }

        public static void UpdateClient(client CLT)
        {
            ClientDAO.UpdateClient(CLT);
        }

        public static void DeleteClient(client CLT)
        {
            ClientDAO.DeleteClient(CLT);
        }


    }
}
