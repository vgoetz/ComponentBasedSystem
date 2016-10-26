using System;
using System.Collections.Generic;
using System.Linq;
using ComponentBasedSystem.Core.Components;
using ComponentBasedSystem.Core.Nodes;
using ComponentBasedSystem.Core.System;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class MoveSystemFixture {

        [TestCase(0, 0, 00, 0, 0, 00)]
        [TestCase(1, 0, 00, 0, 0, 00)]
        [TestCase(0, 1, 00, 0, 0, 00)]
        [TestCase(1, 1, 00, 0, 0, 00)]
        [TestCase(0, 1, 00, 0, 0, 00)]
        [TestCase(1, 1, 00, 0, 0, 00)]
        [TestCase(0, 0, 45, 0, 0, 00)]
        [TestCase(1, 0, 45, 0, 0, 00)]
        [TestCase(0, 1, 45, 0, 0, 00)]
        [TestCase(1, 1, 45, 0, 0, 00)]
        [TestCase(0, 1, 45, 0, 0, 00)]
        [TestCase(1, 1, 45, 0, 0, 00)]
        public void NoMovementAndNoRotation_ObjectStayAsItIs(int x, int y, int rotation, int velocityX, int velocityY, int angularVelocity) {
            var moveSystem = new MoveSystem();
            var nodeList = new List<Tuple<long, INode>>();
            var tupel = new Tuple<long, INode>(0, new MoveNode {
                PositionComponent = new PositionComponent(x, y, rotation),
                VelocityComponent = new VelocityComponent(velocityX, velocityY, angularVelocity)
            });
        
            nodeList.Add(tupel);
            
            Assert.That(moveSystem, Is.Not.Null);
            Assert.That(tupel, Is.Not.Null);
            Assert.That(nodeList, Is.Not.Null);
            Assert.That(nodeList, Is.Not.Empty);

            moveSystem.Update(1, nodeList);

            var moveNode = nodeList.FirstOrDefault()?.Item2 as MoveNode;

            Assert.That(moveNode != null);
            Assert.That(moveNode.PositionComponent, Is.Not.Null);
            Assert.That(moveNode.VelocityComponent, Is.Not.Null);

            Assert.That(moveNode.PositionComponent.X, Is.EqualTo(x));
            Assert.That(moveNode.PositionComponent.Y, Is.EqualTo(y));
            Assert.That(moveNode.PositionComponent.Rotation, Is.EqualTo(rotation));
        }

        [TestCase(0, 0, 00, 0, 0, 00, 0, 0)]
        [TestCase(0, 0, 00, 0, 1, 00, 0, 1)]
        [TestCase(0, 0, 00, 1, 0, 00, 1, 0)]
        [TestCase(0, 0, 00, 1, 1, 00, 1, 1)]

        [TestCase(0, 1, 00, 0, 0, 00, 0, 1)]
        [TestCase(0, 1, 00, 0, 1, 00, 0, 2)]
        [TestCase(0, 1, 00, 1, 0, 00, 1, 1)]
        [TestCase(0, 1, 00, 1, 1, 00, 1, 2)]

        [TestCase(1, 0, 00, 0, 0, 00, 1, 0)]
        [TestCase(1, 0, 00, 0, 1, 00, 1, 1)]
        [TestCase(1, 0, 00, 1, 0, 00, 2, 0)]
        [TestCase(1, 0, 00, 1, 1, 00, 2, 1)]

        [TestCase(1, 1, 00, 0, 0, 00, 1, 1)]
        [TestCase(1, 1, 00, 0, 1, 00, 1, 2)]
        [TestCase(1, 1, 00, 1, 0, 00, 2, 1)]
        [TestCase(1, 1, 00, 1, 1, 00, 2, 2)]
        public void MovementButNoRotation_ObjectStayAsItIs(int x, int y, int rotation, int velocityX, int velocityY, int angularVelocity, int resultX, int resultY) {
            var moveSystem = new MoveSystem();
            var nodeList = new List<Tuple<long, INode>>();
            var tupel = new Tuple<long, INode>(0, new MoveNode {
                PositionComponent = new PositionComponent(x, y, rotation),
                VelocityComponent = new VelocityComponent(velocityX, velocityY, angularVelocity)
            });

            nodeList.Add(tupel);

            Assert.That(moveSystem, Is.Not.Null);
            Assert.That(tupel, Is.Not.Null);
            Assert.That(nodeList, Is.Not.Null);
            Assert.That(nodeList, Is.Not.Empty);

            moveSystem.Update(1, nodeList);

            var moveNode = nodeList.FirstOrDefault()?.Item2 as MoveNode;

            Assert.That(moveNode != null);
            Assert.That(moveNode.PositionComponent, Is.Not.Null);
            Assert.That(moveNode.VelocityComponent, Is.Not.Null);

            Assert.That(moveNode.PositionComponent.X, Is.EqualTo(resultX));
            Assert.That(moveNode.PositionComponent.Y, Is.EqualTo(resultY));
            Assert.That(moveNode.PositionComponent.Rotation, Is.EqualTo(rotation));
        }


        [TestCase(0, 0, 10, 0, 0, 00, 0, 0, Result = 10)]
        [TestCase(0, 0, 10, 0, 0, 01, 0, 0, Result = 11)]
        [TestCase(0, 0, 10, 0, 0, 10, 0, 0, Result = 20)]
        [TestCase(0, 0, 13, 0, 0, 13, 0, 0, Result = 26)]
        //[TestCase(0, 0, 359, 0, 0, 2, 0, 0, Result = 1)]

        //[TestCase(0, 0, 10, 0, 0, -00, 0, 0, Result = 10)]
        //[TestCase(0, 0, 00, 0, 0, -00, 0, 0, Result = 00)]
        //[TestCase(0, 0, 01, 0, 0, -02, 0, 0, Result = 359)]
        //[TestCase(0, 0, 10, 0, 0, -01, 0, 0, Result = 09)]
        //[TestCase(0, 0, 10, 0, 0, -10, 0, 0, Result = 00)]
        //[TestCase(0, 0, 13, 0, 0, -13, 0, 0, Result = 00)]
        //[TestCase(0, 0, 359, 0, 0, -2, 0, 0, Result = 357)]
        public int NoMovementButRotation_ObjectRotates(int x, int y, int rotation, int velocityX, int velocityY, int angularVelocity, int resultX, int resultY) {
            // Given
            var moveSystem = new MoveSystem();
            var nodeList = new List<Tuple<long, INode>>();
            var tupel = new Tuple<long, INode>(0, new MoveNode {
                PositionComponent = new PositionComponent(x, y, rotation),
                VelocityComponent = new VelocityComponent(velocityX, velocityY, angularVelocity)
            });
            nodeList.Add(tupel);

            // When
            moveSystem.Update(1, nodeList);
            var moveNode = nodeList.FirstOrDefault()?.Item2 as MoveNode;

            // Then
            Assert.That(moveNode != null);
            return moveNode.PositionComponent.Rotation;
        }

    }
}
