using ComponentBasedSystem.Core.Components;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class ComponentFixture {

        [Test]
        public void CreatePositionComponentWithDefaults() {
            var positionComponent = new PositionComponent();

            Assert.That(positionComponent, Is.Not.Null);
        }

        [Test]
        public void CreatePositionComponentWithConstructorValues() {
            var positionComponent = new PositionComponent(1, 2);

            Assert.That(positionComponent, Is.Not.Null);
            Assert.That(positionComponent.X, Is.EqualTo(1));
            Assert.That(positionComponent.Y, Is.EqualTo(2));
        }

        [Test]
        public void CreatePositionComponentAndChangeValues() {
            var positionComponent = new PositionComponent(1, 2);
            positionComponent.X = 3;
            positionComponent.Y = 4;

            Assert.That(positionComponent.X, Is.EqualTo(3));
            Assert.That(positionComponent.Y, Is.EqualTo(4));
        }




        [Test]
        public void CreateVelocityComponentWithDefaults() {
            var velocityComponent = new VelocityComponent();

            Assert.That(velocityComponent, Is.Not.Null);
        }

        [Test]
        public void CreateVelocityComponentWithConstructorValues() {
            var velocityComponent = new VelocityComponent(1, 2, 45);

            Assert.That(velocityComponent, Is.Not.Null);
            Assert.That(velocityComponent.VelocityX, Is.EqualTo(1));
            Assert.That(velocityComponent.VelocityY, Is.EqualTo(2));
            Assert.That(velocityComponent.Rotation, Is.EqualTo(45));
        }

        [Test]
        public void CreateVelocityComponentAndChangeValues() {
            var velocityComponent = new VelocityComponent(1, 2, 45);
            velocityComponent.VelocityX = 3;
            velocityComponent.VelocityY = 4;
            velocityComponent.Rotation = 90;

            Assert.That(velocityComponent.VelocityX, Is.EqualTo(3));
            Assert.That(velocityComponent.VelocityY, Is.EqualTo(4));
            Assert.That(velocityComponent.Rotation, Is.EqualTo(90));
        }
    }
}