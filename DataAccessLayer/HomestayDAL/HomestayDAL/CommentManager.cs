using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    class CommentManager
    {
        public void Comment_Insert(Comment comment)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                HomestayEntities1.Comments.Add(comment);
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void Comment_Update(Comment comment)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                Comment cms = HomestayEntities1.Comments.First(cm => cm.CommentID == comment.CommentID);
                cms = comment;
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void Comment_Delete(Comment comment)
        {
            try
            {
                HomestayEntities1 HomestayEntities1 = new HomestayEntities1();
                Comment cms = HomestayEntities1.Comments.First(cm => cm.CommentID == comment.CommentID);
                HomestayEntities1.Comments.Remove(cms);
                HomestayEntities1.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
    }
}
