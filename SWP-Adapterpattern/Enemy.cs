namespace SWP_AdapterPattern {
    internal abstract class Enemy {
        public int MaxHP;
        public int ActualHP;
        protected int Alive;

        public virtual void GetHit(int opponentDamage) {
            ActualHP -= opponentDamage;

            if (ActualHP <= 0) {
                Die();
            }
        }

        public virtual void Die() {
            Alive = 0;
        }
    }
}
