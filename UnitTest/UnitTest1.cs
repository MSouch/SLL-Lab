namespace UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestAddingNodesToBeginning()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.AddFirst("Joe Blow");
            list.AddFirst("Joe Schmoe");
            list.AddFirst("John Smith");

            // Assert
            Assert.AreEqual("John Smith", list.GetValue(0));
            Assert.AreEqual("Joe Schmoe", list.GetValue(1));
            Assert.AreEqual("Joe Blow", list.GetValue(2));
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void TestAddingNodesToEnd()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.AddLast("Jane Doe");
            list.AddLast("Bob Bobberson");

            // Assert
            Assert.AreEqual("Jane Doe", list.GetValue(0));
            Assert.AreEqual("Bob Bobberson", list.GetValue(1));
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void TestRemovingFirstNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");

            // Act
            list.RemoveFirst();

            // Assert
            Assert.AreEqual("Dave Daverson", list.GetValue(0));
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestRemovingLastNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Joe Schmoe");

            // Act
            list.RemoveLast();

            // Assert
            Assert.AreEqual("Joe Blow", list.GetValue(0));
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestGetValueAtIndex()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");

            // Act
            string valueAtIndex1 = list.GetValue(1);

            // Assert
            Assert.AreEqual("Joe Schmoe", valueAtIndex1);
        }

        [TestMethod]
        public void TestSizeOfList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddLast("Joe Schmoe");

            // Act & Assert
            Assert.AreEqual(2, list.Count);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetValueAtIndex_OutOfRange()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act & Assert
            string value = list.GetValue(0); // Should IndexOutOfRangeException here
        }

        [TestMethod]
        public void TestRemovingFromEmptyList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.RemoveFirst();
            list.RemoveLast();

            // Assert
            Assert.AreEqual(0, list.Count);
        }
    }
}