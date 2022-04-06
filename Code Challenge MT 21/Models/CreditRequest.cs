using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_Challenge_MT_21.Models
{
    public class CreditRequest
    {
        public bool Decision { get; set; }
        public double InterestRate { get; set; }

        public CreditRequest CalculateInterest(double creditAmount, int term, double existingCredit)
        {
            CreditRequest cr = new CreditRequest();
            cr.Decision = false;
            cr.InterestRate = 0.0;

            if (creditAmount > 2000 && creditAmount < 69000)
            {
                cr.Decision = true;
                double totalFutureDebt = creditAmount + existingCredit;
                if (totalFutureDebt < 20000)
                {
                    cr.InterestRate = 3;
                }
                else if (totalFutureDebt > 60000)
                {
                    cr.InterestRate = 6;
                }
                else if (totalFutureDebt >= 40000 && totalFutureDebt < 60000)
                {
                    cr.InterestRate = 5;
                }
                else cr.InterestRate = 4;   //if totalFutureDebt is between 20000 and 39999
            }
            return cr;
        }
    }
}