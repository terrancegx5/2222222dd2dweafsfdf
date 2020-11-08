using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vacation Budget Planner!");

            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Where would you like to go " + name + "? " + "Mexico or Jamaica?");

            string country = Console.ReadLine();

            Console.WriteLine("How many days would you like to spend in " + country + "?");

            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much money would you like to spend in " + country + "?");

            int money = Convert.ToInt16(Console.ReadLine());

            int perDay = money / days;

            Console.WriteLine("Hey " + name + ", you are going to " + country + " for " + days + " with $" + money

              +  " for spending money. You can spend $" + perDay +" per day.");

            Console.ReadLine();
        }
    }
}
