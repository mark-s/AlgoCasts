using System;
using Code;
using NUnit.Framework;
using Shouldly;

namespace Tests
{
    [TestFixture]
    public class ReverseStringTests
    {
        private Func<string, string> _reverser;

        [SetUp]
        public void Setup()
        {
            var rs = new ReverseString();
            _reverser = rs.ReverseV1;
            //_reverser = rs.ReverseV2;
        }

        [Test]
        public void Reverse_reverses_a_string()
        {
            // Arrange
            var stringToReverse = "abcd";

            // Act 
            var result = _reverser(stringToReverse);

            // Assert
            result.ShouldBe("dcba");
        }

        [Test]
        public void Reverse_reverses_a_string_starting_with_spaces()
        {
            // Arrange
            var stringToReverse = "  abcd";

            // Act 
            var result = _reverser(stringToReverse);

            // Assert
            result.ShouldBe("dcba  ");
        }

        [Test]
        public void Reverse_reverses_a_string_apple()
        {
            // Arrange
            var stringToReverse = "apple";

            // Act 
            var result = _reverser(stringToReverse);

            // Assert
            result.ShouldBe("elppa");
        }

        [Test]
        public void Reverse_reverses_a_string_greetings()
        {
            // Arrange
            var stringToReverse = "Greetings!";

            // Act 
            var result = _reverser(stringToReverse);

            // Assert
            result.ShouldBe("!sgniteerG");
        }



    }
}
