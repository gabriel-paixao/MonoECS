using System;

namespace MonoECS.Core
{
    public class EntityBuilder
    {
        private readonly World world;
        private readonly Entity entity;
        private bool isBuilt = false;

        public EntityBuilder(World world, Entity entity)
        {
            this.world = world;
            this.entity = entity;
        }

        public EntityBuilder With<T>(T component) where T : IComponent
        {
            if (isBuilt) throw new InvalidOperationException("Cannot add components after entity is built.");
            world.GetComponents<T>().AddComponent(entity, component);
            return this;
        }

        public Entity Build()
        {
            if (isBuilt) throw new InvalidOperationException("Entity already built.");
            isBuilt = true;
            return entity;
        }
    }

}
