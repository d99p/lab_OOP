using System;

namespace Lab1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h1 = new Hotel();
            h1.name = "Dolphin";
            h1.floorNum = 6;
            h1.roomNum = 15;
            h1.maxVisitors = 120;
            h1.currVisitors = 64;
            h1.isNoSmoking = false;
            h1.HotelStat();
            h1.AddVisitors(8);
            h1.ReduceVisitors(6);
            h1.currInfo();
            Console.ReadKey();
        }
    }
}
