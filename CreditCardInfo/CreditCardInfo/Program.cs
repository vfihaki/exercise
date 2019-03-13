using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInfo
{
    class CreditCard
    {
        public string CCName { get; set; }
        public double CCNum {private get; set; }
        public int DigitSecNum {private get; set; }
        public string ExpDate { get; set; }
        public CreditCard(string _ccname, double _ccnum, int _digitsecnum, string _expdate)
        {
            CCName = _ccname; 
            CCNum = _ccnum;
            DigitSecNum = _digitsecnum;
            ExpDate = _expdate;
        }
        public string CardDetail()

        {

            return $"Name: {CCName}\nExpiring Date: {ExpDate}";

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard[] creditcard = new CreditCard[1];
            for (int i = 0; i < creditcard.Length; i++)
            {
                Console.WriteLine("***********************************************\n\tPlease enter your Credit Card details\n***********************************************");
                Console.Write("Enter the name on the card: ");
                string CcName = Console.ReadLine();
                Console.Write("Enter credit card number: ");
                double CcNum = double.Parse(Console.ReadLine());
                Console.Write("Enter the 3 digit security number: ");
                int DigitSecNum = int.Parse(Console.ReadLine());
                Console.Write("Enter the expiring date: ");
                string ExpDate = Console.ReadLine();
                Console.Clear();
                CreditCard cc1 = new CreditCard(CcName, CcNum, DigitSecNum, ExpDate);
                creditcard[i] = cc1;
            }

            for (int i = 0; i < creditcard.Length; i++)
            {
                Console.WriteLine($"Hi {creditcard[i].CCName} here is you information\n******************************************\n{creditcard[i].CardDetail()}\n******************************************");
            }
            Console.ReadLine();
        }
    }
}
