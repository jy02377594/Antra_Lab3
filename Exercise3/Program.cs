using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 2;
            HouseholdAccounts ha = new HouseholdAccounts();
            while(times-- > 0)
            {
                ha.AddExpense();
            }

            Console.WriteLine("----Show Expense----");
            Console.WriteLine("Enter Category");
            string category = Console.ReadLine();
            Console.WriteLine("Start Time");
            string startTime = Console.ReadLine();
            Console.WriteLine("End Time");
            string endTime = Console.ReadLine();

            ha.ShowExpense(category, startTime, endTime);
        }
    }
}
