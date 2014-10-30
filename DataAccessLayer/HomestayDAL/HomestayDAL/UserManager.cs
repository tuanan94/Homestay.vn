using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    class UserManager
    {
        public void User_Insert(User user)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                HomestayEntities1.Users.Add(user);
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void User_Update(User user)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                User us = HomestayEntities1.Users.First(u => u.UserID == user.UserID);
                us = user;
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void User_Delete(User user)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                User us = HomestayEntities1.Users.First(u => u.UserID == user.UserID);
                HomestayEntities1.Users.Remove(us);
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
    }
}
