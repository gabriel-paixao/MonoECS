using System.Collections.Generic;

namespace MonoECS.Core
{
    public class Dispatcher
    {
        private List<ISystem> systems = new();

        public void AddSystem(ISystem system)
        {
            systems.Add(system);
        }

        public void Dispatch(World world)
        {
            foreach (var system in systems)
            {
                system.Run(world);
            }
        }
    }
}
