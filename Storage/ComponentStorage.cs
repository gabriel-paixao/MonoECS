using System.Collections.Generic;
using System.Linq;
using MonoECS.Core;

namespace MonoECS.Storage
{
    public class ComponentStorage<T> : IComponentStorage where T : IComponent
    {
        private Dictionary<int, T> components = new();
        private World world;

        public ComponentStorage(World world)
        {
            this.world = world;
        }

        public void AddComponent(Entity entity, T component)
        {
            components[entity.Id] = component;
        }

        public bool TryGetComponent(Entity entity, out T component)
        {
            return components.TryGetValue(entity.Id, out component);
        }

        public IEnumerable<T> GetAllComponents()
        {
            return components.Values;
        }

        public IEnumerable<Entity> GetAllEntities()
        {
            return components.Keys.Select(id => world.GetAllEntities()[id]);
        }

        public bool HasComponent(Entity entity)
        {
            return components.ContainsKey(entity.Id);
        }
    }
}
