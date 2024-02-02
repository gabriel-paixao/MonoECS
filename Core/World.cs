using System;
using System.Collections.Generic;
using System.Linq;
using MonoECS.Storage;

namespace MonoECS.Core
{
    public class World
    {
        private int nextEntityId = 0;
        private Dictionary<int, Entity> entities = new Dictionary<int, Entity>();
        private Dictionary<Type, object> storages = new Dictionary<Type, object>();

        public EntityBuilder CreateEntity()
        {
            var entity = new Entity(nextEntityId++);
            entities[nextEntityId] = entity;
            return new EntityBuilder(this, entity);
        }
        public List<Entity> GetAllEntities()
        {
            return entities.Values.ToList();
        }

        public ComponentStorage<T> GetComponents<T>() where T : IComponent
        {
            var type = typeof(T);
            if (!storages.ContainsKey(type))
            {
                storages[type] = new ComponentStorage<T>(this);
            }
            return storages[type] as ComponentStorage<T>;
        }

        public ComponentStorage<T> GetStorage<T>() where T : IComponent
        {
            var type = typeof(T);
            if (!storages.ContainsKey(type))
            {
                storages[type] = new ComponentStorage<T>(this);
            }
            return (ComponentStorage<T>)storages[type];
        }

        public static List<Entity> Join2(params IComponentStorage[] storages)
        {
            var commonEntities = new List<Entity>();

            if (storages == null || storages.Length == 0) return commonEntities;

            commonEntities = storages[0].GetAllEntities().ToList();
            foreach (var storage in storages.Skip(1))
            {
                var currentEntities = storage.GetAllEntities();
                commonEntities = commonEntities.Intersect(currentEntities).ToList();
            }

            return commonEntities;
        }
    }
}
