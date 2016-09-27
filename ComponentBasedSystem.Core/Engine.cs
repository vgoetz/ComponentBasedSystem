using System.Collections.Generic;
using System.Linq;

namespace ComponentBasedSystem.Core {
    public class Engine : IEngine {

        private readonly Dictionary<long, IEntity> _entities;

        public Engine() {
            _entities = new Dictionary<long, IEntity>();
        }

        public long AddEntity(IEntity entity) {

            long newKey = 0;

            if (_entities.Any()) {
                newKey = _entities.LastOrDefault().Key + 1;
            }

            _entities.Add(newKey, entity);

            return newKey;
        }

        public IEntity GetEntity(int id) {
            if (_entities.con)
        }

        //public IList<IComponent> GetComponentsFromEntity(int id) {

        //    if (_entities.ContainsKey(id)) {
        //        return _entities[id].;
        //    }

        //    return new List<IComponent>();
        //}

        public int GetEntityCount() {
            return _entities.Count;
        }

    }
}
