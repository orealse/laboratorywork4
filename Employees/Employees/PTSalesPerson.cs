using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class PTSalesPerson : Salesperson
    {
        public PTSalesPerson(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfOpts)
            : base (fullName, age, empID, currPay, ssn)
        { }
        // Ошибка! Этот метод переопределять нельзя!
        public override void GiveBonus (float amount)
        { }
    }
}
