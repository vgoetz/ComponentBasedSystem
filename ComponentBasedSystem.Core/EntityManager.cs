using System.Collections.Generic;
using System.Linq;

namespace ComponentBasedSystem.Core {

    public interface IEntityManager {
        long AddEntity(IEnumerable<IEntityComponent> entityComponentList);
        int GetEntityCount();
        IList<IEntityComponent> GetEntityComponents(int id);
    }

    public class EntityManager : IEntityManager {
        private readonly Dictionary<long, List<IEntityComponent>> _entities;

        public EntityManager() {
            _entities = new Dictionary<long, List<IEntityComponent>>();
        }

        public long AddEntity(IEnumerable<IEntityComponent> entityComponentList) {

            long newKey = 0;

            if (_entities.Any()) {
                newKey = _entities.LastOrDefault().Key + 1;
            }

            _entities.Add(newKey, entityComponentList.ToList());

            return newKey;
        }

        public int GetEntityCount() {
            return _entities.Count;
        }

        public IList<IEntityComponent> GetEntityComponents(int id) {

            if (_entities.ContainsKey(id)) {
                return _entities[id];
            }

            return new List<IEntityComponent>();
        }
    }
}
