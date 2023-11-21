using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrate
{
    public class Decoration_A : IBilesen
    {
        private IBilesen _bilesen;

        public Decoration_A(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }
        public string Operation() => _bilesen.Operation() + "Yazılım Tanımlı Ağlar Projesi Geliştiriliyor"; 
    }
}
