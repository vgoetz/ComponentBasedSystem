using System.Collections.Generic;
using Autofac;
using ComponentBasedSystem.Core;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EngineFixture {


        [Test]
        public void Engine_DefaultListOfEntitiesIsEmpty() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            Assert.That(engine.GetEntityCount(), Is.EqualTo(0));
        }

        //[Test]
        //public void Engine_DefaultComponentListOfNotFoundEntityIsEmpty() {
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
        //    var container = builder.Build();

        //    IEngine engine = container.Resolve<IEngine>();

        //    Assert.That(engine.GetEntityCount(), Is.EqualTo(0));

        //    var componentsOfEntity = engine.Get(0);
        //    Assert.That(componentsOfEntity, Is.Not.Null);
        //    Assert.That(componentsOfEntity, Is.Empty);
        //}

        [Test]
        public void AddNewEntityToEntityManager_CountWillBe1() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            engine.AddEntity(new );

            Assert.That(engine.GetEntityCount(), Is.EqualTo(1));
        }

        [Test]
        public void AddNewEntityToEntityManager_IncrementedId() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            var id = engine.AddEntity(new List<IComponent> { new HealthComponent() });

            Assert.That(id, Is.EqualTo(0));

            id = engine.AddEntity(new List<IComponent> { new HealthComponent() });

            Assert.That(id, Is.EqualTo(1));
        }

        [Test]
        public void AddNewEntityWith5ComponentsToEntityManager() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            engine.AddEntity(new List<IComponent> { new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent(),
                                                                 new HealthComponent()
            });

            var componentsOfEntity = engine.GetEntitys(0);

            Assert.That(componentsOfEntity.Count, Is.EqualTo(5));
        }


        [Test]
        public void AddNewEntityToEntityManager_GetAddedComponentsOfNewEntity() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            engine.AddEntity(new List<IComponent> { new HealthComponent() });

            var componentsOfEntity = engine.GetEntitys(0);
            
            Assert.That(componentsOfEntity.Count, Is.EqualTo(1));
            Assert.That(componentsOfEntity[0], Is.TypeOf(typeof(HealthComponent)));
        }


    }
}
