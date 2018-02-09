using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    public class Object
    {
        // Виртуальные чены.
        public virtual bool Equals(object obj);
        protected virtual void Finalize();
        public virtual int GetHashCode();
        public virtual string ToString();

        // Невиртуальные члены уровня экземпляяра.
        public Type GetType();
        protected object MemberwiseClone();

        // Статические члены.
        public static bool Equals(object objA, object objB);
        public static bool ReferenceEquals(object objA, object objB);
    }
}
