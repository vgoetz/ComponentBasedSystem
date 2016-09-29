using Autofac;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Engine;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class ResolveWithAutofacFixture {

        [Test]
        public void ResolveEntityManagerWithAutofacTest() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Engine>().As<IEngine>().SingleInstance();
            var container = builder.Build();

            IEngine engine = container.Resolve<IEngine>();

            Assert.That(engine, Is.Not.Null);
            Assert.That(engine, Is.TypeOf(typeof (Engine)));
        }

        [Test]
        public void ResolveHealthComponentWithAutofacTest() {
            var builder = new ContainerBuilder();
            builder.RegisterType<HealthComponent>().SingleInstance();
            var container = builder.Build();

            HealthComponent entityManager = container.Resolve<HealthComponent>();

            Assert.That(entityManager, Is.Not.Null);
            Assert.That(entityManager, Is.TypeOf(typeof(HealthComponent)));
        }
    }
}
