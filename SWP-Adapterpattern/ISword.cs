namespace SWP_AdapterPattern {
    internal interface ISword {
        string Name { get; set; }

        int Weight { get; set; }

        int Damage { get; set; }

        int Price { get; set; }

        int WeaponReach { get; set; }

        public void NormalAttack(Enemy enemy);
    }
}
