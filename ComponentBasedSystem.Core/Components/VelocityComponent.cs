namespace ComponentBasedSystem.Core.Components {

    public class VelocityComponent : IComponent {

        private int _angularVelocity;
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }

        public int AngularVelocity {
            get { return _angularVelocity; }
            set {
                if (value < 0) {
                    _angularVelocity = 0;
                } else if (value > 360) {
                    _angularVelocity = 360;
                } else {
                    _angularVelocity = value;
                }
            }
        }

        public VelocityComponent() {
            VelocityX = 0;
            VelocityY = 0;
            AngularVelocity = 0;
        }

        public VelocityComponent(int velocityX, int velocityY, int angularVelocity) {
            VelocityX = velocityX;
            VelocityY = velocityY;
            AngularVelocity = angularVelocity;
        }


    }
}