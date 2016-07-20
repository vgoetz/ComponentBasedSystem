using Autofac;
using ComponentBasedSystem.Core;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class ResolveWithAutofacFixture {

        [Test]
        public void ResolveEntityManagerWithAutofacTest() {
            var builder = new ContainerBuilder();
            builder.RegisterType<EntityManager>().As<IEntityManager>().SingleInstance();
            var container = builder.Build();

            IEntityManager entityManager = container.Resolve<IEntityManager>();

            Assert.That(entityManager, Is.Not.Null);
            Assert.That(entityManager, Is.TypeOf(typeof (EntityManager)));
        }
    }
}
