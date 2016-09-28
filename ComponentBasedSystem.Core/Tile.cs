namespace ComponentBasedSystem.Core {

    public class Tile : IEntity {
        private readonly PositionComponent _positionComponent;

        public Tile(PositionComponent positionComponent) {
            _positionComponent = positionComponent;
        }
    }
}