using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomestayDAL;
namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseManager HouseManager = new HouseManager();
            
            House hs = new House();
            hs.HouseID = 0;
            hs.Price=56;
            hs.HouseScore = 0;
            hs.Address = "sai gon";
            hs.NORating = 0;
            hs.UserID = 0;
            hs.Detail = "sssssssssss";
            HouseManager.House_Update(hs);

        }
    }
}
