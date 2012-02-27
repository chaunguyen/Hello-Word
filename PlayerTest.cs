using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    class PlayerTest
    {
        public static void Chau_Test()
        {

            Console.WriteLine("Please input name of the football player: ");
            string n = string.Format(Console.ReadLine());

            Console.WriteLine("Please input Income for the football player: ");
            double income=0;
            bool isNumber = false;
            while (isNumber == false)
            {
                try
                {
                    income = double.Parse(Console.ReadLine());
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number:");
                }
            }

            Console.WriteLine("Please input Tax percent for the football player:(is number 1 - 100) ");
            double taxpercent=0;
            isNumber = false;
            while (isNumber == false)
            {
                try
                {
                    taxpercent = double.Parse(Console.ReadLine());
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number from 1 - 100:");
                }
            }
            
            PlayerIncome p = new PlayerIncome(n, income, taxpercent);
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is detail of the football player after using PlayerIncome.cs to calculate:");
            p.DisplayDetail();

            Console.WriteLine("Please input grade of the football player: ");
            int grade = 0;
            isNumber = false;
            while (isNumber == false)
            {
                try
                {
                    grade = int.Parse(Console.ReadLine());
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number:");
                }
            }
            Console.WriteLine("Please input rate of the football player: ");
            double rate = 0;
            isNumber = false;
            while (isNumber == false)
            {
                try
                {
                    rate = double.Parse(Console.ReadLine());
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a number:");
                }
            }
            TournamentIncome t = new TournamentIncome(n,grade,rate);
            Console.WriteLine("Please input Grade Bonus Percent for the football player: (is number 1 to 100)");
            t.GRADE_BONUS_PERCENT = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is detail of player after using TournamentIncome.cs to calculate:");
            t.DisplayDetail();

            
        }
    }
}
