using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CarPartDAO : CarPartContext
    {

        //Car Add usign Sql Linq
        public static void AddCarPart(sparepart CARPART)
        {
            try
            {
                db.spareparts.InsertOnSubmit(CARPART);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Car Part Listing usign Sql Linq
        public static List<sparepart> GetCarParts()
        {
            return db.spareparts.ToList();
        }


        //Car part Delete usign Sql Linq

        public static void DeleteCar(sparepart CARPART)
        {
            try
            {
                sparepart CARpART = db.spareparts.First(x => x.part_id == CARPART.part_id);
                db.spareparts.DeleteOnSubmit(CARpART);
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateCarPartQty(sparepart CARPART)
        {
            try
            {
                sparepart cARpart = db.spareparts.First(x => x.part_id == CARPART.part_id);
                cARpart.part_quentity = CARPART.part_quentity;
                cARpart.date_updated = CARPART.date_updated;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //Car Part update usign Sql Linq
        public static void UpdateCarPart(sparepart CARPART)
        {
            try
            {
                sparepart CARpART = db.spareparts.First(x => x.part_id == CARPART.part_id);
                CARpART.part_name = CARPART.part_name;
                CARpART.part_menufecturer = CARPART.part_menufecturer;
                CARpART.part_warrenty = CARPART.part_warrenty;
                CARpART.part_price = CARPART.part_price;
                CARpART.part_quentity = CARPART.part_quentity;
                CARpART.image_path = CARPART.image_path;
                CARpART.date_updated = CARPART.date_updated;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
