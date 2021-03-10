namespace SWP_AdapterPattern {
    internal class LongSword : ISword {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int weight;
        public int Weight { get { return weight; } set { weight = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; } }

        private int weaponReach;
        public int WeaponReach { get { return weaponReach; } set { weaponReach = value; } }

        public LongSword(string Name, int Weight, int Damage, int Price, int WeaponReach) {
            this.Name = Name;
            this.Weight = Weight;
            this.Damage = Damage;
            this.Price = Price;
            this.WeaponReach = WeaponReach;
        }

        public void NormalAttack(Enemy enemy) {
            enemy.GetHit(Damage);
        }

        public void SweepAttak(Enemy[] enemies) {
            foreach (Enemy enemy in enemies) {
                enemy.GetHit(Damage);
            }
        }
    }
}
