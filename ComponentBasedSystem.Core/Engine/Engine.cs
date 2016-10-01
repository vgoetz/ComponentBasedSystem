using System;
using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Entities;
using ComponentBasedSystem.Core.Nodes;

namespace ComponentBasedSystem.Core.Engine {

    public class Engine : IEngine {

        private readonly Dictionary<long, Entity> _entities = new Dictionary<long, Entity>();
        private readonly List<Tuple<long, INode>> _nodes = new List<Tuple<long, INode>>();

        public long AddEntity(Entity entity) {

            long newKey = 0;

            if (_entities.Any()) {
                newKey = _entities.LastOrDefault().Key + 1;
            }

            _entities.Add(newKey, entity);
            foreach (INode node in entity.GetNodes()) {
                _nodes.Add(new Tuple<long, INode>(newKey, node));
            }

            return newKey;
        }
        
        public IReadOnlyDictionary<long, Entity> Entities => _entities;
        public List<Tuple<long, INode>> Nodes => _nodes;
    }
}
