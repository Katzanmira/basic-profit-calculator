using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66840_Mehmet_Said_Unlu_T2
{
    public class Company
    {
        public string GenerateID(string productName)
        {
            Random rand = new Random();
            string id = $"{productName.Substring(0, 2)}-{rand.Next(100000, 999999)}";
            return id;
        }

        public double CalculateSumOfAll(int quantity, double price)
        {
            return quantity * price;
        }

        public double CalculateTotalProfit(double sumOfAll, double profitPercentage)
        {
            return sumOfAll * (profitPercentage / 100);
        }
    }
}
