using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CarDAO : CarContext
    {


        //Car Add usign Sql Linq
        public static bool AddCar(car CAR)
        {
            try
            {
                db.cars.InsertOnSubmit(CAR);
                db.SubmitChanges();

                var createdCar = db.cars.FirstOrDefault(x => x.car_id == CAR.car_id);

                if (createdCar == null) return false;
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
       
        }

        public static List<CarDetailsDTO> GetCars()
        {
            List<car> carsFromDb = db.cars.ToList();

            var carDtos = new List<CarDetailsDTO>();

            foreach (car car in carsFromDb)
            {
                var carDto = new CarDetailsDTO();
                carDto.CarID = car.car_id;
                carDto.ModelName = car.modelname;
                carDto.Brand = car.brand;
                carDto.Color = car.color;
                carDto.FuelType = car.fueltype;
                carDto.Availability = car.availability;
                carDto.Type = car.type;
                //carDto.price = car.price;


                carDtos.Add(carDto);
            }
            return carDtos;
        }

        public static void UpdateCarAva(car CAR)
        {
            try
            {
                car cAR = db.cars.First(x => x.car_id == CAR.car_id);
                cAR.availability = CAR.availability;
                cAR.updated_date = CAR.updated_date;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Car Delete usign Sql Linq

        public static void DeleteCar(car CAR)
        {
            try
            {
                car CaR = db.cars.First(x => x.car_id == CAR.car_id);
                db.cars.DeleteOnSubmit(CaR);
                db.SubmitChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }



        //Car update usign Sql Linq
        public static void UpdateCar(car CAR)
        {
            try
            {
                car cAR = db.cars.First(x => x.car_id == CAR.car_id);
                cAR.modelname = CAR.modelname;
                cAR.brand = CAR.brand;
                cAR.color = CAR.color;
                cAR.availability = CAR.availability;
                cAR.fueltype = CAR.fueltype;
                cAR.price = CAR.price;
                cAR.type = CAR.type;
                cAR.image_path = CAR.image_path;
                cAR.updated_date = CAR.updated_date;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
