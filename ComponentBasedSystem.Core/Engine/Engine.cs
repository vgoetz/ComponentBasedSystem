﻿using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Entities;

namespace ComponentBasedSystem.Core.Engine {

    public class Engine : IEngine {

        private readonly Dictionary<long, Entity> _entities;

        public Engine() {
            _entities = new Dictionary<long, Entity>();
        }

        public long AddEntity(Entity entity) {

            long newKey = 0;

            if (_entities.Any()) {
                newKey = _entities.LastOrDefault().Key + 1;
            }

            _entities.Add(newKey, entity);

            return newKey;
        }
        
        public IReadOnlyDictionary<long, Entity> Entities => _entities;
    }
}
