using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CardAbstract;
using static Uzcard.delegates;
namespace Uzcard
{
    public class main
    {
        public static void Main()
        {
            uzcard plastik = new uzcard(456000);
            //humo pulOtkazma = new humo(plastik.Money);
            plastik.amount = 12000;

            plastik.Money = plastik.SetAmount(plastik.amount);
            Console.WriteLine($"SetAmount = {plastik.Money}");

            plastik.Money = plastik.SetAmount(plastik.amount);
            Console.WriteLine($"AddWithBonus = {plastik.Money}");
            
            humo humoCard = new humo();
            humoCard.Money = plastik.Money;
            void hisob(float Cost) {
                humoCard.cost = Cost;
                humoCard.Money = humoCard.pay(humoCard.cost);
                Console.WriteLine($"Money = {humoCard.Money}");
            }
            HisobKitob yechim = hisob;
            yechim(48000);
            yechim(51000);
            yechim(1000000);
           
        }
    }
}
