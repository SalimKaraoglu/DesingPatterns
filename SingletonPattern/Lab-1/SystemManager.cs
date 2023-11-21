using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager;

        //Burada amaç  bu sınıfın dışarıdan erişilerek örnekleminin alınmasını önlemektir
        private SystemManager() { }

        //Sınıfın örneklemini dışarıdan alamayacağız çünkü constractor'ı private yaptık bunun yerine nesneyi sınıfın kendi içerisinde kontrollü bir şekilde costum bir method yada property üzerinden nesnenin üretilmesini kontrol altına alarak üretilmesini temin altına aldık 
        public static SystemManager CreateSingletonObject()
        {
            //Uygulamanın herhangi bir yerinde "SystemManager." diyerek CreateSingletonObject() methodunu çağırabilir SystemManager.cs sınıfının örneklemini bir şart doğrultusunda yaratır yada temin eder 
            if (_systemManager == null)
            {
                _systemManager = new SystemManager();
            }

            //_systemManager nesne zaten dolu ise direkt onu teslim eder.
            return _systemManager; // nesneyi döndürür
        }
        public void CreateLog() => Console.WriteLine("A log was created!");
    }
}
