namespace ComponentBasedSystem.Core {

    public class HealthComponent : IEntityComponent {

        private int _health;
        private int _armour;

        public HealthComponent(int health, int armour) {
            _health = health;
            _armour = armour;
        }

        public void TakeDamage(int damage) {
            var damageToTake = damage - _armour;

            if (damageToTake > 0) {
                _health -= damageToTake;
            }
        }
    }
}