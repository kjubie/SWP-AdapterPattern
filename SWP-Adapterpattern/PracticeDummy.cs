namespace SWP_AdapterPattern {
    internal class PracticeDummy : Enemy {
        public PracticeDummy(int HP, int Alive) {
            MaxHP = HP;
            ActualHP = HP;
            this.Alive = Alive;
        }

        public override void GetHit(int opponentDamage) {
            ActualHP -= opponentDamage;

            if (ActualHP <= (MaxHP / 10)) {
                ActualHP = MaxHP / 10;
            }
        }
    }
}
