using System.Collections.Generic;
using Autofac;
using ComponentBasedSystem.Core;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EntityManagerFixture {


        [Test]
        public void AddNewEntityToEntityManager_DefaultListOfEntitiesIsEmpty() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            Assert.That(entityManager.GetEntityCount(), Is.EqualTo(0));
        }

        [Test]
        public void AddNewEntityToEntityManager_DefaultComponentListOfNotFoundEntityIsEmpty() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            Assert.That(entityManager.GetEntityCount(), Is.EqualTo(0));

            var componentsOfEntity = entityManager.GetEntityComponents(0);
            Assert.That(componentsOfEntity, Is.Not.Null);
            Assert.That(componentsOfEntity, Is.Empty);
        }

        [Test]
        public void AddNewEntityToEntityManager_CountWillBe1() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            entityManager.AddEntity(new List<IEntityComponent> { new HealthComponent() });

            Assert.That(entityManager.GetEntityCount(), Is.EqualTo(1));
        }

        [Test]
        public void AddNewEntityToEntityManager_IncrementedId() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            var id = entityManager.AddEntity(new List<IEntityComponent> { new HealthComponent() });

            Assert.That(id, Is.EqualTo(0));

            id = entityManager.AddEntity(new List<IEntityComponent> { new HealthComponent() });

            Assert.That(id, Is.EqualTo(1));
        }

        [Test]
        public void AddNewEntityWith5ComponentsToEntityManager() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            entityManager.AddEntity(new List<IEntityComponent> { new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent()
            });

            var componentsOfEntity = entityManager.GetEntityComponents(0);

            Assert.That(componentsOfEntity.Count, Is.EqualTo(5));
        }


        [Test]
        public void AddNewEntityToEntityManager_GetAddedComponentsOfNewEntity() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            entityManager.AddEntity(new List<IEntityComponent> { new HealthComponent() });

            var componentsOfEntity = entityManager.GetEntityComponents(0);
            
            Assert.That(componentsOfEntity.Count, Is.EqualTo(1));
            Assert.That(componentsOfEntity[0], Is.TypeOf(typeof(HealthComponent)));
        }


    }
}
