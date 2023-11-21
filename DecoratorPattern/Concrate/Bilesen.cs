using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrate
{
    public class Bilesen : IBilesen
    {
        public string Operation() => "Çalıştığı Firma İsmi ";
    }
}
