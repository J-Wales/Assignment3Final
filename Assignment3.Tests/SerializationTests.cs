using Assignment3;

namespace Assignment3.Tests
{
    public class SerializationTests
    {
        private ILinkedListADT users;
        private readonly string testFileName = "test_users.bin";

        [SetUp]
        public void Setup()
        {
            // Uncomment the following line
            this.users = new SLL();

            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        /// <summary>
        /// Tests the object was serialized.
        /// </summary>
        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            Assert.IsTrue(File.Exists(testFileName));
        }

        /// <summary>
        /// Tests the object was deserialized.
        /// </summary>
        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            ILinkedListADT deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            
            Assert.IsTrue(users.Count() == deserializedUsers.Count());
            
            for (int i = 0; i < users.Count(); i++)
            {
                User expected = users.GetValue(i);
                User actual = deserializedUsers.GetValue(i);

                Assert.AreEqual(expected.Id, actual.Id);
                Assert.AreEqual(expected.Name, actual.Name);
                Assert.AreEqual(expected.Email, actual.Email);
                Assert.AreEqual(expected.Password, actual.Password);
            }
        }

        [Test]
        public void TestIsEmpty()
        {
            // Arrange
            bool a;
            
            // Act
            a = users.IsEmpty();

            // Assert
            Assert.IsFalse(a);
        }

        [Test]
        public void TestClear()
        {
            // Arrange
            int expected = 0;

            // Act
            users.Clear();
            int actual = users.Count();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAddLast()
        {
            // Arrange

            // Act

            // Assert

        }

        [Test]
        public void TestAddFirst()
        {
            // Arrange

            // Act

            // Assert

        }

        [Test]
        public void TestAdd()
        {
            // Arrange

            // Act

            // Assert
            
        }

        [Test]
        public void TestReplace()
        {
            // Arrange
            User expected = new User(5, "Jane Doe", "doejane@hotmail.com", "un!d3nt!f!ed");

			// Act
			users.Replace(new User(5, "Jane Doe", "doejane@hotmail.com", "un!d3nt!f!ed"), 1);
            User actual = users.GetValue(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCount()
        {
            // Arrange
            int expected = 4;

            // Act
            int actual = users.Count();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestRemoveFirst()
        {
            // Arrange

            // Act

            // Assert
            
        }

        [Test]
        public void TestRemoveLast()
        {
            // Arrange
            User expected = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

            // Act
            users.RemoveLast();
            User actual = users.GetValue(2);

			// Assert
            Assert.AreEqual(expected, actual);
		}

        [Test]
        public void TestRemove()
        {
            // Arrange
            User expected = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

			// Act
			users.Remove(1);
            User actual = users.GetValue(1);

			// Assert
            Assert.AreEqual(expected, actual);
		}

        [Test]
        public void TestGetValue()
        {
            // Arrange
            User expected = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");

            // Act
            User actual = users.GetValue(1);

            // Assert
            Assert.AreEqual(expected, actual);
		}

        [Test]
        public void TestIndexOf()
        {
            // Arrange
            int expected1 = 1;
            int expected2 = -1;

			// Act
			int actual1 = users.IndexOf(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            int actual2 = users.IndexOf(new User(5, "Jane Doe", "doejane@hotmail.com", "un!d3nt!f!ed"));

			// Assert
			Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [Test]
        public void TestContains()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = users.Contains(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));

			// Act
			Assert.AreEqual(expected, actual);
		}
    }
}