using System.Collections.Generic;

namespace ComponentBasedSystem.Core {

    public interface IEntityManager {
        
    }

    public class EntityManager : IEntityManager {
        private Dictionary<int, List<IEntityComponent>> _entities;

        public EntityManager() {
            _entities = new Dictionary<int, List<IEntityComponent>>();
        }
    }
}
