using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class LoginBLL
    {

        public static login AddLogins(login LOGIN)
        {
            return LoginDAO.AddLogins(LOGIN);
        }


        public static List<login> GetLogins(string Uname, string Pawd)
        {
            return LoginDAO.GetLogins(Uname, Pawd);
        }

        public static void UpdateLogin(login LOGIN)
        {
            LoginDAO.UpdateLogin(LOGIN);
        }

    }
}
