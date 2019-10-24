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
            if (outVisitors >= 1)      
                currVisitors = (currVisitors - outVisitors);
            else
                Console.WriteLine("Невірний запис");
        }

        public void CurrInfo() // Info hotel Visitors
        {
            Console.WriteLine("Кількість постоляців на даний момент: " + currVisitors);
        }

        public void Interest() // Interest hotel
        {
            double intrs = InterestMethod;
            Console.WriteLine("Заповнення готелю в даний момент:" + Convert.ToInt32(intrs) + "%");
        }

        private double InterestMethod => (double)currVisitors / maxVisitors * 100;

        public void Profitability()
        {
            double prof = ProfitabilityMethod;
            Console.WriteLine("Дохід:" + Convert.ToInt32(prof) + "%");
        }

        private double ProfitabilityMethod => (inMoney - outMoney) / inMoney * 100;  // Profitability Hotel
                                                                                    
    }
}
