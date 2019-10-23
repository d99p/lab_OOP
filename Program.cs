using System;

namespace Testing_Program
{
    class Program
    {

        static void Main()
        {
            Hotel h1 = new Hotel // add Object 
            {
                name = "Dolphin",
                floorNum = 6,
                roomNum = 15,
                maxVisitors = 120,
                currVisitors = 78,
                isNoSmoking = false,
                inMoney = 250000,
                outMoney = 73000
            };
            h1.HotelStat();   // out data obj
            h1.AddVisitors(8);
            h1.ReduceVisitors(6);
            h1.CurrInfo();
            h1.Interest();
            h1.Profitability();
            Console.ReadKey();
        }

    }
}