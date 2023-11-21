using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab_2
{
    public class SingletonClass
    {
        private static SingletonClass _singletonObject;  // Field

        private SingletonClass()
        {

        }
        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    _singletonObject = new Lab_2.SingletonClass();
                }
                return _singletonObject;
            }
        }
        public int Toplam(int s1, int s2) => s1 + s2;   // Method
    }
}
