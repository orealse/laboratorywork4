using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
          /*  Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Console.ReadLine();*/

            // Лучшая система бонусов!

            Manager chucky = new Manager("Chucky", 50, 92, 10000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            Salesperson fran = new Salesperson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();

           /* OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();

            OuterClass.PublicInnerClass inner2;
            inner2 = new OuterClass.PublicInnerClass();
            Console.ReadLine();*/
        }

        static void  GrivePromotion(Employee emp)
        {
            // Повысить зарплату...
            // Предоставить место на парковке компании...
            Console.WriteLine("{0} was promoted!", emp.Name);
        }
        static void CastingExamples()
        {
            // Manager "является" System.Object, поэтому можно сохранять
            // ссылку на Manager в переменной типа object.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GrivePromotion((Manager)frank);
            // Manager также "является" Employee.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

            GrivePromotion(moonUnit);
            // PTSalesPerrson "является" Salesperson.
            Salesperson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "101-12-1119", 90);
            GrivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is Salesperson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((Salesperson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }
}
