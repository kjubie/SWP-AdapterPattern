namespace SWP_AdapterPattern {
    internal class SwordAdapter : ISword {
        private string name;
        public string Name { get { return name; } set { name = value; sword_Legacy.Name = value; } }

        private int weight;
        public int Weight { get { return weight; } set { weight = value; sword_Legacy.Weight = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; sword_Legacy.Damage = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; sword_Legacy.Price = value; } }

        private int weaponReach;
        public int WeaponReach { get { return weaponReach; } set { weaponReach = value; } }

        private readonly Sword_Legacy sword_Legacy;

        public SwordAdapter(string Name, int Weight, int Damage, int Price, int WeaponReach) {
            sword_Legacy = new Sword_Legacy();

            this.Name = Name;
            this.Weight = Weight;
            this.Damage = Damage;
            this.Price = Price;
            this.WeaponReach = WeaponReach;
        }

        public void NormalAttack(Enemy enemy) {
            enemy.GetHit(sword_Legacy.Attak());
        }
    }
}
