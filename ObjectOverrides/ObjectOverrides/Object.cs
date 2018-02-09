using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    public class Object
    {
        /* Виртуальные чены.
        public virtual bool Equals(object obj);
        protected virtual void Finalize();
        public virtual int GetHashCode();
        public virtual string ToString();

        // Невиртуальные члены уровня экземпляра.
        public Type GetType();
        protected object MemberwiseClone();

        // Статические члены.
        public static bool Equals(object objA, object objB);
        public static bool ReferenceEquals(object objA, object objB);*/

        static void StaticMembersOfObject()
        {
            // Статические члены System.Object.
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));
        }
    }
}
