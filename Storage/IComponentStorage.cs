using System.Collections.Generic;
using MonoECS.Core;

namespace MonoECS
{
    public interface IComponentStorage
    {
        IEnumerable<Entity> GetAllEntities();
        bool HasComponent(Entity entity);
    }

}
