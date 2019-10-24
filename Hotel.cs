using System;

namespace Testing_Program
{
    class Hotel 
    {  
        public string name;  // initilization
        public int floorNum, roomNum, maxVisitors, currVisitors;
        public bool isNoSmoking;
        public double inMoney, outMoney;

        public void HotelStat() // Hotel information
        {
        Console.WriteLine(" ПОТОЧНИЙ СТАН ГОТЕЛЮ ");
        Console.WriteLine("Ім'я готелю: " + name);
        Console.WriteLine("Кількість поверхів: " + floorNum);
        Console.WriteLine("Кількість кімнат " + roomNum);
        Console.WriteLine("Максимальна кількість гостей " + maxVisitors);
        Console.WriteLine("Поточна кількість гостей " + currVisitors);
        Console.WriteLine("Дозволено куріння в готелі " + isNoSmoking);
        
        }

        public void AddVisitors(int num) //Add visitors
        {
        
            if (num >= 1)
                currVisitors = (currVisitors + num);
            else
                Console.WriteLine("Невірний запис");
        
        }
        public void ReduceVisitors(int outVisitors) // ReduceVisitors 
        {
        currVisitors = (currVisitors - outVisitors);
        }

        public void CurrInfo() // Info hotel Visitors
        {
        Console.WriteLine("Кількість постоляців на даний момент: " + currVisitors);
        }

        public void Interest() // Interest hotel
        {
            double intrs = NewMethod;
            Console.WriteLine("Заповнення готелю в даний момент:" + Convert.ToInt32(intrs) + "%");
        }

        private double NewMethod => (double)currVisitors / maxVisitors * 100;

        public void Profitability()
        {

            double prof = ( inMoney / outMoney * 100); // Profitability Hotel
            Console.WriteLine("Дохід:" + Convert.ToInt32(prof) + "%");
        }
    }
}
