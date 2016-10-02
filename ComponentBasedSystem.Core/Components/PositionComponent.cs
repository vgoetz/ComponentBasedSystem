namespace ComponentBasedSystem.Core.Components {

    public class PositionComponent : IComponent {

        private int _rotation;
        public int X { get; set; }
        public int Y{ get; set; }

        public int Rotation {
            get { return _rotation; }
            set {
                if (value < 0) {
                    _rotation = 0;
                }
                else if (value > 360) {
                    _rotation = 360;
                }
                else {
                    _rotation = value;
                }
            }
        }

        public PositionComponent() {
            X = 0;
            Y = 0;
        }

        public PositionComponent(int x, int y, int rotation) {
            X = x;
            Y = y;
            Rotation = rotation;
        }

        
    }
}