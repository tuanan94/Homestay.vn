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
                HomestayEntities HomestayEntities = new HomestayEntities();
                HomestayEntities.Comments.Add(comment);
                HomestayEntities.SaveChanges();
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
                HomestayEntities HomestayEntities = new HomestayEntities();
                Comment cms = HomestayEntities.Comments.First(cm => cm.CommentID == comment.CommentID);
                cms = comment;
                HomestayEntities.SaveChanges();
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
                HomestayEntities HomestayEntities = new HomestayEntities();
                Comment cms = HomestayEntities.Comments.First(cm => cm.CommentID == comment.CommentID);
                HomestayEntities.Comments.Remove(cms);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
    }
}
