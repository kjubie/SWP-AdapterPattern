using System;
using System.Collections.Generic;

namespace SWP_AdapterPattern {
    internal class Program {
        private static void Main(string[] args) {
            Dictionary<string, ISword> Swords = new Dictionary<string, ISword>();
            Swords.Add("Short", new ShortSword("Short", 1, 10, 2000, 1));
            Swords.Add("Medium", new SwordAdapter("Medium", 4, 8, 2500, 2));
            Swords.Add("Long", new LongSword("Long", 6, 20, 4000, 3));

            ISword ChoosenSword;
            if (!Swords.TryGetValue(args[0], out ChoosenSword)) {
                Console.WriteLine("Sword does not exist!");
                return;
            }

            Console.WriteLine("Choosen Sword: Name = " + ChoosenSword.Name + ", Weight = " + ChoosenSword.Weight + "kg, Damage = " + ChoosenSword.Damage + ", Price = " + ChoosenSword.Price + " Gold, Weapon Reach = " + ChoosenSword.WeaponReach / 2 + "m");

            Enemy Dummy = new PracticeDummy(100, 1);

            ChoosenSword.NormalAttack(Dummy);

            Console.WriteLine("You attacked the Training Dummy! Dummy HP: " + Dummy.ActualHP + "/" + Dummy.MaxHP);
        }
    }
}
