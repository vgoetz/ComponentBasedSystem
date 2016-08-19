using Autofac;
using ComponentBasedSystem.BootstrapperAndMondules;
using ComponentBasedSystem.Core;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class BootstrapperFixture {

        [Test]
        public void ResolveEntityManagerWithAutofacAfterBootstrapperTest() {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.CreateContainer();
            var entityManager = container.Resolve<IEntityManager>();

            Assert.That(entityManager, Is.Not.Null);
            Assert.That(entityManager, Is.TypeOf(typeof(EntityManager)));
        }
    }
}
