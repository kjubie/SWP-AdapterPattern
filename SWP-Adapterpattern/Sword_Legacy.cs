namespace SWP_AdapterPattern {
    internal class Sword_Legacy {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int weight;
        public int Weight { get { return weight; } set { weight = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; } }

        public Sword_Legacy() {

        }

        public void InitSword(string Name, int Weight, int Damage, int Price) {
            this.Name = Name;
            this.Weight = Weight;
            this.Damage = Damage;
            this.Price = Price;
        }

        public int Attak() {
            //Legacy Swords have a lower Base Damage but the actual Damage the Sword deals scales with their weight.
            //The Legacy Sword Attack Function also only calculates the Damage. The newer Swords take the Enemy as a parameter and deal the Damage directly.
            return damage * (weight / 2);
        }
    }
}
