using Autofac;
using ComponentBasedSystem.BootstrapperAndMondules;
using ComponentBasedSystem.Core.Engine;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class BootstrapperFixture {

        [Test]
        public void ResolveEntityManagerWithAutofacAfterBootstrapperTest() {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.CreateContainer();
            var entityManager = container.Resolve<IEngine>();

            Assert.That(entityManager, Is.Not.Null);
            Assert.That(entityManager, Is.TypeOf(typeof(Engine)));
        }
    }
}
