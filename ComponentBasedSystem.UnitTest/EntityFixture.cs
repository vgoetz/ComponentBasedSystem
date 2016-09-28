
using ComponentBasedSystem.Core;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EntityFixture {

        [Test]
        public void CreateNewEmptyTileEntity() {
            var tile = new Tile(null);
            Assert.That(tile, Is.Not.Null);
        }

        [Test]
        public void CreateTileWithPositionComponent() {
            var positionComponent = new PositionComponent();
            var tile = new Tile(positionComponent);

            Assert.That(positionComponent, Is.Not.Null);
            Assert.That(tile, Is.Not.Null);
        }

        
    }
}
