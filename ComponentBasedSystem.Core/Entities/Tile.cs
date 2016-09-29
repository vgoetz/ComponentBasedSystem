using System.Collections.Generic;
using ComponentBasedSystem.Core.Components;

namespace ComponentBasedSystem.Core.Entities {

    public class Tile : Entity {

        public Tile(PositionComponent positionComponent) : base(new List<IComponent> {positionComponent}) {
            
        }
    }
}