using System;
using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Nodes;

namespace ComponentBasedSystem.Core.Entities {

    public abstract class Entity {

        private readonly Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>();

        protected Entity(List<IComponent> components) {
            foreach (IComponent component in components.Where(c => c != null)) {
                _components.Add(component.GetType(), component);
            }
        }

        public IReadOnlyDictionary<Type, IComponent> Components => _components;

        public IEnumerable<INode> GetNodes() {
            if (_components.ContainsKey(typeof (PositionComponent)) &&
                _components.ContainsKey(typeof (VelocityComponent))) {
                yield return new MoveNode {
                    PositionComponent = _components[typeof(PositionComponent)] as PositionComponent,
                    VelocityComponent = _components[typeof(VelocityComponent)] as VelocityComponent
                };
            }
        }
    }
}