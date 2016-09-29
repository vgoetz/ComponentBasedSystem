using ComponentBasedSystem.Core.Engine;
using ComponentBasedSystem.Core.Entities;
using NUnit.Framework;

namespace ComponentBasedSystem.UnitTest {

    [TestFixture]
    public class EngineFixture {


        [Test]
        public void Engine_DefaultListOfEntitiesIsEmpty() {
            var engine = new Engine();

            Assert.That(engine, Is.Not.Null);
            Assert.That(engine.Entities, Is.Not.Null);
            Assert.That(engine.Entities, Is.Empty);
        }
        

        [Test]
        public void AddNewEntityToEntityManager_CheckEntityList() {
            var engine = new Engine();
            engine.AddEntity(new Tile(null));

            Assert.That(engine.Entities, Is.Not.Null);
            Assert.That(engine.Entities.Count, Is.EqualTo(1));
            Assert.That(engine.Entities.ContainsKey(0));
        }

        [Test]
        public void AddNewEntityToEntityManager_CheckIdsAndStoredObjects() {

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

        


    }
}
