using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        // Поля данных.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        public BenefitPackage Benefits
        {
            get
            {
                return empBenefits;
            }
            set
            {
                empBenefits = value;
            }
        }

        public class BenefitPackage
        {
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        //Конструкторы.
        public Employee() { }
        public Employee(string name, int id, float pay, string ssn)
            : this(name, 0, id, pay, ssn) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SSN = ssn;
        }
    }
}
