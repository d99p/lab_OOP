using System;
using System.Collections.Generic;
using System.Text;


namespace Lab1_OOP
{
    class Hotel
    {
    public string name;
    public  int floorNum;
    public int roomNum;
    public int maxVisitors;
    public int currVisitors;
    public bool isNoSmoking;

       public void HotelStat() // Hotel information
        {
            Console.WriteLine("Стан готелю: ");
            Console.WriteLine("Ім'я готелю: " + name);
            Console.WriteLine("Кількість поверхів: " + floorNum);
            Console.WriteLine("Кількість кімнат " + roomNum);
            Console.WriteLine("Максимальна кількість гостей " + maxVisitors);
            Console.WriteLine("Поточна кількість гостей " + currVisitors);
            Console.WriteLine("Дозволено куріння в готелі " + isNoSmoking);
        }

        public void AddVisitors(int num) //Add visitors
        {
           { 
            if (num >= 1)
                currVisitors = (currVisitors + num);
            else
                Console.WriteLine("Невірний запис");
            }
        }
        public void ReduceVisitors(int outVisitors) // ReduceVisitors 
        {
            currVisitors = (currVisitors - outVisitors);
        }

        public void currInfo() // Info hotel Visitors
        {
            Console.WriteLine("Кількість постоляців на даний момент: " + currVisitors);
        }
    }
}
