using System;
using System.Linq;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Engine;
using ComponentBasedSystem.Core.Entities;
using ComponentBasedSystem.Core.Nodes;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EngineFixture {


        [Test]
        public void DefaultListOfEntitiesIsEmpty() {
            var engine = new Engine();

            Assert.That(engine, Is.Not.Null);
            Assert.That(engine.Entities, Is.Not.Null);
            Assert.That(engine.Entities, Is.Empty);
        }
        

        [Test]
        public void AddNewEntity_EntityListHasOneEntry() {
            var engine = new Engine();
            engine.AddEntity(new Tile(null));

            Assert.That(engine.Entities, Is.Not.Null);
            Assert.That(engine.Entities.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddNewEntity_CheckIdsAndStoredObjects() {

            Engine engine = new Engine();

            var entityTile = new Tile(null);
            var id = engine.AddEntity(entityTile);
            Assert.That(id, Is.EqualTo(0));

            var entityBear = new Bear(null, null);
            id = engine.AddEntity(entityBear);
            Assert.That(id, Is.EqualTo(1));

            Assert.That(engine.Entities, Is.Not.Null);
            Assert.That(engine.Entities.Count, Is.EqualTo(2));
            Assert.That(engine.Entities.ContainsKey(0));
            Assert.That(engine.Entities.ContainsKey(1));
            Assert.That(engine.Entities[0] == entityTile);
            Assert.That(engine.Entities[1] == entityBear);
        }


        public void DefaultListOfNodesIsEmpty() {
            var engine = new Engine();

            Assert.That(engine, Is.Not.Null);
            Assert.That(engine.Nodes, Is.Not.Null);
            Assert.That(engine.Nodes, Is.Empty);
        }

        [Test]
        public void AddNewEntityWithComponents_NodesListHasOneEntry() {
            var engine = new Engine();
            engine.AddEntity(new Bear(new PositionComponent(), new VelocityComponent()));

            Assert.That(engine.Nodes, Is.Not.Null);
            Assert.That(engine.Nodes.Count, Is.EqualTo(1));
        }

        public void AddNewEntity_CheckNodes() {
            Engine engine = new Engine();

            var tile = new Tile(null);
            engine.AddEntity(tile);

            var positionComponent = new PositionComponent(1, 2, 45);
            var velocitycomponent = new VelocityComponent(3, 4, 90);
            var bear = new Bear(positionComponent, velocitycomponent);
            engine.AddEntity(bear);

            Assert.That(engine.Nodes, Is.Not.Null);
            Tuple<long, INode> node = engine.Nodes.FirstOrDefault();

            Assert.That(node != null);
            var id = node.Item1;
            var moveNode = node.Item2 as MoveNode;
            
            Assert.That(id, Is.EqualTo(1));
            Assert.That(moveNode != null);
            Assert.That(moveNode, Is.TypeOf(typeof(MoveNode)));
            Assert.That(moveNode.PositionComponent.X, Is.EqualTo(1));
            Assert.That(moveNode.PositionComponent.Y, Is.EqualTo(2));
            Assert.That(moveNode.PositionComponent.Rotation, Is.EqualTo(45));
            Assert.That(moveNode.VelocityComponent.VelocityX, Is.EqualTo(3));
            Assert.That(moveNode.VelocityComponent.VelocityY, Is.EqualTo(4));
            Assert.That(moveNode.VelocityComponent.AngularVelocity, Is.EqualTo(90));
        }


    }
}
