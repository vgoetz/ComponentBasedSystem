namespace ComponentBasedSystem.Core.Components {

    public class PositionComponent : IComponent {
        public int X { get; set; }
        public int Y { get; set; }

        public PositionComponent() {
            X = 0;
            Y = 0;
        }

        public PositionComponent(int x, int y) {
            X = x;
            Y = y;
        }

        
    }
}