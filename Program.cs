using System;
using System.Linq;

namespace DamageCounter
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Enter unit Max # of shots");
         var numbshotin = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numbshotin);

         Console.WriteLine("Enter BS/WS of attaking unit");
         var hitchance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weapon Strength");
         int wepstr = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter weapon's AP");
         int wepAp = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter Weapons Damage");
         int wepDam = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter target units toughness");
         int targtough = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter target units normal save");
         int targNsave = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter target units invulnerable save");
         int targinvul = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter target units wounds");
         int Targwnd = Convert.ToInt32(Console.ReadLine());

            bestsave bestsave = new bestsave();

            int bestAP = bestsave.save(targNsave, targinvul, wepAp);

            //Console.WriteLine(bestAPtest);

            var numshotdevide = numbshotin / 2;
            var numbshot = (int)numshotdevide;

            //   Console.WriteLine(numbshot);

            int finaldamage;

            finaldamage = numbshot

            Console.WriteLine("You deal " + finaldamage + " number of wounds on average");

        
        }
    }

}
