using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    public class HouseManager
    {
        public void House_Insert(House house)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                HomestayEntities.Houses.Add(house);
                HomestayEntities.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
          
            
        }
        public void House_Update(House house)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                House hs = HomestayEntities.Houses.First(h => h.HouseID == house.HouseID);
                hs.UserID = house.UserID;
                hs.Price = house.Price;
                hs.Title = house.Title;
                hs.Detail = house.Detail;
                hs.Status = house.Status;
                hs.Address = house.Address;
                hs.AvailableDate = house.AvailableDate;
                hs.HouseScore = house.HouseScore;
                hs.NORating = house.NORating;
                hs.RatingDate = house.RatingDate;

                HomestayEntities.SaveChanges();
            }
            catch(Exception e){
                Console.WriteLine(e.InnerException);
            }
        }
        public void House_delete(House house)
        { 
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                House hs = HomestayEntities.Houses.First(h => h.HouseID == house.HouseID);
                HomestayEntities.Houses.Remove(hs);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }

        }
    }
}
