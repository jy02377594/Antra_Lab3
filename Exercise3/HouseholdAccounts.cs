using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class HouseholdAccounts
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }

        public void AddExpense() {
            while (true)
            {
                Console.WriteLine("Enter Date(YYYYMMDD format)");
                Date = Console.ReadLine();
                int year = int.Parse(Date.Substring(0, 4));
                int month = int.Parse(Date.Substring(4, 2));
                int day = int.Parse(Date.Substring(6, 2));
                if (year > 3000 || year < 1000) Console.WriteLine("the year beyond the range");
                else if (month > 12 || month < 1) Console.WriteLine("the month beyond the range");
                else if (day > 31 || month < 1) Console.WriteLine("the day beyond the range");
                else break;
            }
            while (true)
            {
                Console.WriteLine("Enter Decription");
                Description = Console.ReadLine();
                if (Description == "")
                    Console.WriteLine("Description can not be empty");
                else break;
            }
            Console.WriteLine("Enter Category");
            Category = Console.ReadLine();
            Console.WriteLine("Enter Amount");
            Amount = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowExpense(string category, string startTime, string endTime)
        {
            if (category == Category)
            {
                if (int.Parse(Date) <= int.Parse(endTime) && int.Parse(Date) >= int.Parse(startTime))
                {
                    int year = int.Parse(Date.Substring(0, 4));
                    int month = int.Parse(Date.Substring(4, 2));
                    int day = int.Parse(Date.Substring(6, 2));
                    Console.WriteLine($"Display: ({day}/{month}/{year} - {Description} - {Category} - {Math.Round((float)Amount,2)})");
                }
            }
            else
            {
                Console.WriteLine("not data in this category");
            }
        }
    }
}
