using System.Collections.Generic;

namespace ComponentBasedSystem.Core {
    public interface IEntityManager {
        long AddEntity(IEnumerable<IEntityComponent> entityComponentList);
        int GetEntityCount();
        IList<IEntityComponent> GetEntityComponents(int id);
    }
}