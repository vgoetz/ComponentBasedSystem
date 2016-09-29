namespace ComponentBasedSystem.Core.Components {

    public class HealthComponent : IComponent {

        private int _health;
        private int _armour;

        public void SetHealth(int health) {
            _health = health;
        }

        public void SetArmour(int armour) {
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