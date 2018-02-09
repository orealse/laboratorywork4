using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Класс Salesperson запечатал метод GiveBonus()!
    class Salesperson : Employee
    {
        public int SalesNumber
        {
            get;
            set;
        }

        public Salesperson(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfOpts;
        }

        
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
                base.GiveBonus(amount * salesBonus);
            }

        }

       /* public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", numberOfOptions);
        }*/
    }
}
