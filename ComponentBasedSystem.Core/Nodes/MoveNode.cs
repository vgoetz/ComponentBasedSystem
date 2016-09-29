using ComponentBasedSystem.Core.Components;

namespace ComponentBasedSystem.Core.Nodes {

    public class MoveNode : INode {
        public PositionComponent PositionComponent { get; set; }
        public VelocityComponent VelocityComponent { get; set; }
    }
}
