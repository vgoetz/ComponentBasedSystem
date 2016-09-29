using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Entities;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EntityFixture {

        [Test]
        public void CreateNewEmptyTileEntity() {
            var tile = new Tile(null);
            Assert.That(tile, Is.Not.Null);
            Assert.That(tile.Components, Is.Empty);
        }

        [Test]
        public void CreateTileWithAllNeededComponents() {
            var positionComponent = new PositionComponent();
            var tile = new Tile(positionComponent);

            Assert.That(positionComponent, Is.Not.Null);
            Assert.That(tile, Is.Not.Null);
        }

        [Test]
        public void CreateBearWithAllNeededComponents() {
            var positionComponent = new PositionComponent();
            var velocitycomponent = new VelocityComponent();
            var bear = new Bear(positionComponent, velocitycomponent);

            Assert.That(bear, Is.Not.Null);
        }

        [Test]
        public void CreateBearAndCheckForHisComponents() {
            var positionComponent = new PositionComponent();
            var velocitycomponent = new VelocityComponent();
            var bear = new Bear(positionComponent, velocitycomponent);

            Assert.That(bear, Is.Not.Null);
            Assert.That(bear.Components, Is.Not.Null);
            Assert.That(bear.Components, Is.Not.Empty);
            Assert.That(bear.Components.ContainsKey(typeof(PositionComponent)));
            Assert.That(bear.Components.ContainsKey(typeof(VelocityComponent)));
        }
        
    }


}
