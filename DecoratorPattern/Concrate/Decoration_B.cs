using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrate
{
    public class Decoration_B : IBilesen
    {
        private IBilesen _bilesen;
        public Decoration_B(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }
        public string Operation()=> _bilesen.Operation() + "RPA Projeleri Geliştiriyorum";
        public string EkDavranis() => "Yüksek Lisans Yapıyorum";
    }
}
