using SingletonPattern.Lab_1;
using SingletonPattern.Lab_2;

#region Lab-1
//Aşagıdaki kodu aktif yapınca constarcter bize kızdı Çünkü erişilebilir değil. Teorik olrak söylediğimiz gibi single ile üretilen nesneleri uygulamanın herhangi bir yerinde çağırırız ama yeniden üretemeyiz
//SystemManager systemManager = new SystemManager();
SystemManager systemManager = SystemManager.CreateSingletonObject();
// Bu costum method sayesinde SystemManager.cs sınıfında bir nesne sınıfın içerisinde kontrollü bir şekilde üretilecek ve bize buradan geri döndürülecek
systemManager.CreateLog();

//systemManager değişkeninin üzerinden SystemManager.cs sınıfın içerisinde olan Create() methoduna eriştim. Normalde bu method olduğundan ona sadece örneklem üzerinden erişilebilir.
#endregion

#region Lab - 2
Console.WriteLine($"Sonuç => {SingletonClass.SingletonObject.Toplam(3,2)}");
#endregion
