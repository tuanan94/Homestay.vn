using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    class RatingLogManager
    {

        public void RatingLog_Insert(RatingLog rl)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                HomestayEntities.RatingLogs.Add(rl);
                HomestayEntities.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            } 
        }
         public void RatingLog_Update(RatingLog rl)
         {
             try
             {
                 HomestayEntities HomestayEntities = new HomestayEntities();
                 RatingLog rat = HomestayEntities.RatingLogs.First(r => r.UserID == rl.UserID);
                 rat= rl;
                 HomestayEntities.SaveChanges();
             }
             catch (Exception e)
             {

                 Console.WriteLine(e.InnerException);
             }
         }
         public void RatingLog_Delete(RatingLog rl)
         {
             try
             {
                 HomestayEntities HomestayEntities = new HomestayEntities();
                 RatingLog rlg = HomestayEntities.RatingLogs.First(u => u.UserID == rl.UserID);
                 HomestayEntities.RatingLogs.Remove(rlg);
                 HomestayEntities.SaveChanges();
             }
             catch (Exception e)
             {

                 Console.WriteLine(e.InnerException);
             }
         }


        }

    }


