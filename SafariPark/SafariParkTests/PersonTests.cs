using System.Runtime.CompilerServices;

namespace SafariParkTests
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("",  "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            // Arrange
            var subject = new Person(fName, lName);
            // Act
            var result = subject.FullName;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
        [TestCase("Noita", "Persons", -10)]
        [TestCase("Als-OnNotta", "Persons", 121)]
        public void GivenInvalidAge_ReturnsException(string fName, string lName, int invalidAge)
        {
            //var subject = new Person("Noita", "Persons");
            //subject.Age = (-10);
            Assert.That(() => new Person(fName, lName, invalidAge), Throws.TypeOf<ArgumentException>().With.Message.Contains("Age must be between 0 and 120"));
        }
        
    }
}