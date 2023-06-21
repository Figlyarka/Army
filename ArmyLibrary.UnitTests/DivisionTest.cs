using NUnit.Framework;

namespace Army
{
    //Тесты на Класс "Подразделение" из задания 14.

    [TestFixture]
    public class DivisionTest
    {
        private Division _division;
        private List<Serviceman> _listServiceman;

        [SetUp]
        public void Setup()
        {
            var john = new Serviceman("John", "Fogerty", 122){NumMillitaryUnit = 223};
            var alex = new Serviceman("Alex", "Smith", 235){NumMillitaryUnit = 223};
            var peter = new Serviceman("Peter", "Gabriel", 233){NumMillitaryUnit = 223};
            var tom = new Serviceman("Tom", "Fogerty", 532){NumMillitaryUnit = 223};

            _listServiceman = new List<Serviceman>() { john, alex, peter, tom};

            _division = new Division("Tank Division",_listServiceman){UnitNumber = 223};
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(_division.Name, Is.EqualTo("Tank Division"));
            Assert.That(_division.UnitNumber, Is.EqualTo(223));
        }
    
    
        [Test]
        public void IEnumerableTest()
        {
            var i = 0;

            foreach(var member in _division)
                Assert.That(member, Is.SameAs(_listServiceman[i++]));
        }
    }
}

