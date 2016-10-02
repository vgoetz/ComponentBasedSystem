using ComponentBasedSystem.Core.Components;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class VelocityComponentFixture {

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(50)]
        [TestCase(99)]
        [TestCase(180)]
        [TestCase(360)]
        public void SetValidRotations(int rotation) {
            var velocityComponent = new VelocityComponent {
                AngularVelocity = rotation
            };
            
            Assert.That(velocityComponent.AngularVelocity, Is.EqualTo(rotation));
        }

        [TestCase(-1)]
        [TestCase(-50)]
        [TestCase(-180)]
        [TestCase(-360)]
        [TestCase(-361)]
        [TestCase(-999)]
        public void SetRotationValueLowerThan0(int rotation) {
            var velocityComponent = new VelocityComponent {
                AngularVelocity = rotation
            };

            Assert.That(velocityComponent.AngularVelocity, Is.EqualTo(0));
        }

        [TestCase(361)]
        [TestCase(500)]
        [TestCase(999)]
        [TestCase(10000)]
        public void SetRotationValueGreaterThan360(int rotation) {
            var velocityComponent = new VelocityComponent {
                AngularVelocity = rotation
            };

            Assert.That(velocityComponent.AngularVelocity, Is.EqualTo(360));
        }
    }
}