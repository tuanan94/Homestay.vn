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
                HomestayEntities1 HomestayEntities = new HomestayEntities1();
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
                HomestayEntities1 HomestayEntities = new HomestayEntities1();
                House hs = HomestayEntities.Houses.First(h => h.HouseID == house.HouseID);
                hs = house;
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
                HomestayEntities1 HomestayEntities = new HomestayEntities1();
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
