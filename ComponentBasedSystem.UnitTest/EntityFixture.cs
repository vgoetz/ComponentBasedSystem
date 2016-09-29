using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Entities;
using ComponentBasedSystem.Core.Nodes;
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

        [Test]
        public void CreateBearAndGetMoveNodeFromHisComponents() {
            var positionComponent = new PositionComponent();
            var velocitycomponent = new VelocityComponent();
            var bear = new Bear(positionComponent, velocitycomponent);

            IEnumerable<INode> nodes = bear.GetNodes();
            INode firstNode = nodes.FirstOrDefault();

            Assert.That(nodes, Is.Not.Null);
            Assert.That(nodes, Is.Not.Empty);
            Assert.That(firstNode, Is.InstanceOf(typeof(INode)));
            Assert.That(firstNode, Is.InstanceOf(typeof(MoveNode)));
        }

        [Test]
        public void CreateBearAndCheckExctractedMoveNode() {
            var positionComponent = new PositionComponent(1, 2);
            var velocitycomponent = new VelocityComponent(3, 4, 45);
            var bear = new Bear(positionComponent, velocitycomponent);

            IEnumerable<INode> nodes = bear.GetNodes();
            var moveNode = nodes.FirstOrDefault() as MoveNode;

            Assert.That(moveNode != null);
            Assert.That(moveNode.PositionComponent, Is.Not.Null);
            Assert.That(moveNode.VelocityComponent, Is.Not.Null);

            Assert.That(moveNode.PositionComponent.X, Is.EqualTo(1));
            Assert.That(moveNode.PositionComponent.Y, Is.EqualTo(2));
            Assert.That(moveNode.VelocityComponent.VelocityX, Is.EqualTo(3));
            Assert.That(moveNode.VelocityComponent.VelocityY, Is.EqualTo(4));
            Assert.That(moveNode.VelocityComponent.Rotation, Is.EqualTo(45));
        }

    }


}
