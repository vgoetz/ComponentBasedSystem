using System.Collections.Generic;

namespace ComponentBasedSystem.Core {

    public interface IEngine {
        long AddEntity(IEntity entities);
        IEntity GetEntity(int id);

        int GetEntityCount();
    }
}