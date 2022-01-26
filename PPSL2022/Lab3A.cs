//Class: CSE 1321L
//Section: #01 C#
//Term: Spring 2022
//Instructor: Yamini Hanisha Talluri
//Name: Thea Buckler
//Lab#: Lab3A

using System;

namespace Lab3A
{
    class Lab3A
    {
        static void Main(string[] args)
        {
            float amount_owed;
            float APR_rate;
            float min_payment;
            float monthly_percent_rate;
            //string user_input;

            Console.Write("Amount owed: $");
            amount_owed = Convert.ToSingle(Console.ReadLine());

            Console.Write("APR: ");
            APR_rate = Convert.ToSingle(Console.ReadLine()) / 100;

            monthly_percent_rate = APR_rate / 12;
            min_payment = amount_owed * APR_rate /12;

            Console.WriteLine("Monthly percentage rate :{0}", monthly_percent_rate *100);
            Console.WriteLine("Minimum payment: ${0}", min_payment);
            Console.ReadKey();
        }
    }
}
