using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    class ScoreLogManager
    {
        public void Score_Insert(ScoreLog score)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                HomestayEntities.ScoreLogs.Add(score);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void Score_Update(ScoreLog score)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                ScoreLog scs = HomestayEntities.ScoreLogs.First(sc => sc.Score == score.Score);
                scs = score;
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void Score_Delete(ScoreLog score)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                ScoreLog scs = HomestayEntities.ScoreLogs.First(sc => sc.Score == score.Score);
                HomestayEntities.ScoreLogs.Remove(scs);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
    }
}
