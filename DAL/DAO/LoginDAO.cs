using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class LoginDAO : LoginContext
    {

        //Login Add usign Sql Linq
        public static login AddLogins(login lOGIN)
        {
            try
            {
                db.logins.InsertOnSubmit(lOGIN);
                db.SubmitChanges();

                var user = db.logins.FirstOrDefault(u => u.user_name == lOGIN.user_name && u.password == lOGIN.password);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<login> GetLogins(string Uname, string Pawd)
        {

            try
            {
                List<login> list = db.logins.Where(x => x.user_name == Uname && x.password == Pawd).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void UpdateLogin(login LOGIN)
        {
            try
            {
                login lOGIN = db.logins.First(x => x.login_id == LOGIN.login_id);
                lOGIN.user_name = LOGIN.user_name;
                lOGIN.password = LOGIN.password;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




    }
}
