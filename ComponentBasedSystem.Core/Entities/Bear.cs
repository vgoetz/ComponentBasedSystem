using System.Collections.Generic;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Nodes;

namespace ComponentBasedSystem.Core.Entities {

    public class Bear : Entity {

        public Bear(PositionComponent positionComponent, VelocityComponent velocitycomponent)
            : base(new List<IComponent> { positionComponent, velocitycomponent }) { }

    }
}