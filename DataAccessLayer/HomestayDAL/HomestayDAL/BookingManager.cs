using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayDAL
{
    class BookingManager
    {
        public void Booking_Insert(Booking book)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                HomestayEntities.Bookings.Add(book);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
        public void Booking_Update(Booking book)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                Booking bks = HomestayEntities.Bookings.First(bk => bk.BookingID == book.BookingID);
                bks.UserID = book.UserID;
                bks.HouseID = book.HouseID;
                bks.BookingDate = book.BookingDate;
                bks.Status = book.Status;
                bks.StartDate = book.StartDate;
                bks.EndDate = book.EndDate;

                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
        public void Booking_Delete(Booking book)
        {
            try
            {
                HomestayEntities HomestayEntities = new HomestayEntities();
                Booking bks = HomestayEntities.Bookings.First(bk => bk.BookingID == book.BookingID);
                HomestayEntities.Bookings.Remove(bks);
                HomestayEntities.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException);
            }
        }
    }
}
