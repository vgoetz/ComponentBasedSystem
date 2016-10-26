using System;
using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Nodes;

namespace ComponentBasedSystem.Core.System {

    public class MoveSystem : ISystem {

        public void Update(int time, List<Tuple<long, INode>> nodes) {

            foreach (MoveNode moveNode in nodes.Select(n => n.Item2 as MoveNode).Where(n => n != null)) {
                moveNode.PositionComponent.X += moveNode.VelocityComponent.VelocityX*time;
                moveNode.PositionComponent.Y += moveNode.VelocityComponent.VelocityY*time;
                moveNode.PositionComponent.Rotation += moveNode.VelocityComponent.AngularVelocity*time;
            }
        }
    }

}