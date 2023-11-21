using DecoratorPattern.Clients;
using DecoratorPattern.Concrate;
using DecoratorPattern.Interface;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBilesen bilesen = new Bilesen();

            Client.Display("1. Ham Hali => ", bilesen);
            Client.Display("2. Hali Dekarotor_A ile => ", new Decoration_A(bilesen));
            Client.Display("3. Hali Dekarotor_B ile modifiye Edilmiş => " , new Decoration_B(bilesen));
            Client.Display("4. Hali önce Dekarotor_B sonra Dekarotor_A ile Modifiye Edilmiş => " , new Decoration_A(new Decoration_B(bilesen)));
            Client.Display(new Decoration_B(bilesen).EkDavranis(), new Decoration_B(bilesen));

        }
    }
}
