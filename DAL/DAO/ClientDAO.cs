using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO
{
    public class ClientDAO : ClientContext
    {
        //Cient Registartion usign Sql Linq
        public static void AddClient(client CLT)
        {
            try
            {
                db.clients.InsertOnSubmit(CLT);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Client Listing usign Sql Linq
        public static List<client> GetClients()
        {
            return db.clients.ToList();
        }


        //Clients Delete usign Sql Linq

        public static void DeleteClient(client CLT)
        {
            try
            {
                client cLT = db.clients.First(x => x.clt_id == CLT.clt_id);
                db.clients.DeleteOnSubmit(cLT);
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }



        //Client update usign Sql Linq
        public static void UpdateClient(client CLT)
        {
            try
            {
                client Clt = db.clients.First(x => x.clt_id == CLT.clt_id);
                //Clt.clt_name = CLT.clt_name; //need to change to user satic as user name
                Clt.clt_address = CLT.clt_address;
                Clt.clt_mobileNumber = CLT.clt_mobileNumber;
                Clt.clt_updated_date = CLT.clt_updated_date;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
