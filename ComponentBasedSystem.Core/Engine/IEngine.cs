
using ComponentBasedSystem.Core.Entities;

namespace ComponentBasedSystem.Core.Engine {

    public interface IEngine {
        long AddEntity(Entity entities);
        Entity GetEntity(int id);

        int GetEntityCount();
    }
}