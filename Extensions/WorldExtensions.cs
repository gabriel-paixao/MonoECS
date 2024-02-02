using System.Collections.Generic;
using MonoECS.Core;

namespace MonoECS.Extensions
{
    public static class WorldExtensions
    {
        public static IEnumerable<(T1, T2)> Join<T1, T2>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2))
                {
                    yield return (component1, component2);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3)> Join<T1, T2, T3>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3))
                {
                    yield return (component1, component2, component3);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4)> Join<T1, T2, T3, T4>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4))
                {
                    yield return (component1, component2, component3, component4);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5)> Join<T1, T2, T3, T4, T5>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5))
                {
                    yield return (component1, component2, component3, component4, component5);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5, T6)> Join<T1, T2, T3, T4, T5, T6>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        where T6 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();
            var storage6 = world.GetStorage<T6>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5) &&
                    storage6.TryGetComponent(entity, out T6 component6))
                {
                    yield return (component1, component2, component3, component4, component5, component6);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> Join<T1, T2, T3, T4, T5, T6, T7>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        where T6 : IComponent
        where T7 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();
            var storage6 = world.GetStorage<T6>();
            var storage7 = world.GetStorage<T7>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5) &&
                    storage6.TryGetComponent(entity, out T6 component6) &&
                    storage7.TryGetComponent(entity, out T7 component7))
                {
                    yield return (component1, component2, component3, component4, component5, component6, component7);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> Join<T1, T2, T3, T4, T5, T6, T7, T8>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        where T6 : IComponent
        where T7 : IComponent
        where T8 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();
            var storage6 = world.GetStorage<T6>();
            var storage7 = world.GetStorage<T7>();
            var storage8 = world.GetStorage<T8>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5) &&
                    storage6.TryGetComponent(entity, out T6 component6) &&
                    storage7.TryGetComponent(entity, out T7 component7) &&
                    storage8.TryGetComponent(entity, out T8 component8))
                {
                    yield return (component1, component2, component3, component4, component5, component6, component7, component8);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> Join<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        where T6 : IComponent
        where T7 : IComponent
        where T8 : IComponent
        where T9 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();
            var storage6 = world.GetStorage<T6>();
            var storage7 = world.GetStorage<T7>();
            var storage8 = world.GetStorage<T8>();
            var storage9 = world.GetStorage<T9>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5) &&
                    storage6.TryGetComponent(entity, out T6 component6) &&
                    storage7.TryGetComponent(entity, out T7 component7) &&
                    storage8.TryGetComponent(entity, out T8 component8) &&
                    storage9.TryGetComponent(entity, out T9 component9))
                {
                    yield return (component1, component2, component3, component4, component5, component6, component7, component8, component9);
                }
            }
        }

        public static IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> Join<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this World world)
        where T1 : IComponent
        where T2 : IComponent
        where T3 : IComponent
        where T4 : IComponent
        where T5 : IComponent
        where T6 : IComponent
        where T7 : IComponent
        where T8 : IComponent
        where T9 : IComponent
        where T10 : IComponent
        {
            var storage1 = world.GetStorage<T1>();
            var storage2 = world.GetStorage<T2>();
            var storage3 = world.GetStorage<T3>();
            var storage4 = world.GetStorage<T4>();
            var storage5 = world.GetStorage<T5>();
            var storage6 = world.GetStorage<T6>();
            var storage7 = world.GetStorage<T7>();
            var storage8 = world.GetStorage<T8>();
            var storage9 = world.GetStorage<T9>();
            var storage10 = world.GetStorage<T10>();

            foreach (var entity in world.GetAllEntities())
            {
                if (storage1.TryGetComponent(entity, out T1 component1) &&
                    storage2.TryGetComponent(entity, out T2 component2) &&
                    storage3.TryGetComponent(entity, out T3 component3) &&
                    storage4.TryGetComponent(entity, out T4 component4) &&
                    storage5.TryGetComponent(entity, out T5 component5) &&
                    storage6.TryGetComponent(entity, out T6 component6) &&
                    storage7.TryGetComponent(entity, out T7 component7) &&
                    storage8.TryGetComponent(entity, out T8 component8) &&
                    storage9.TryGetComponent(entity, out T9 component9) &&
                    storage10.TryGetComponent(entity, out T10 component10))
                {
                    yield return (component1, component2, component3, component4, component5, component6, component7, component8, component9, component10);
                }
            }
        }
    }
}
