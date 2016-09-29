namespace ComponentBasedSystem.Core.Components {

    public class VelocityComponent : IComponent {
        private int _rotation;
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }

        public int Rotation {
            get { return _rotation; }
            set {
                if (value < 0) {
                    _rotation = 0;
                } else if (value > 360) {
                    _rotation = 360;
                } else {
                    _rotation = value;
                }
            }
        }

        public VelocityComponent(int velocityX, int velocityY, int rotation) {
            VelocityX = velocityX;
            VelocityY = velocityY;
            Rotation = rotation;
        }

        public VelocityComponent() {
            VelocityX = 0;
            VelocityY = 0;
            Rotation = 0;
        }
    }
}