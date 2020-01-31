using FizzBuzzGenerator;
using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzGenerator.Tests
{
    public class GenerateTests
    {

        /*
            Tests:
               - ShouldRunUpToFifteen
               - ShouldRunWithCustomPairs
               - ShouldHaveErrorIfGiveLessThenOne
               - ShouldHaveErrorIfNoPairs
        */

        [Fact]
        public void Generate_ShouldRunUpToFifteen()
        {
            // Arrange
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
            };

            // Act
            List<string> actual = new List<string>();

            FizzBuzz.Generate(15, value =>
            {
                actual.Add(value);
            });

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Generate_ShouldRunWithCustomPairs()
        {
            // Arrange
            List<string> expected = new List<string>()
            {
                "1",
                "2",
                "Jake",
                "4",
                "John",
                "Jake",
                "7",
                "8",
                "Jake",
                "John",
                "11",
                "Jake",
                "13",
                "14",
                "JakeJohn",
            };
            var numberWordPairs = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (3, "Jake"),
                new Tuple<int, string> (5, "John")
            };

            // Act
            List<string> actual = new List<string>();

            FizzBuzz.Generate(15, numberWordPairs, value =>
            {
                actual.Add(value);
            });

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Generate_ShouldHaveErrorIfGiveLessThenOne()
        {
            // Arrange
            List<string> expected = new List<string>()
            {
                "Please use integer that is >= 1"
            };

            // Act
            List<string> actual = new List<string>();

            FizzBuzz.Generate(0, value =>
            {
                actual.Add(value);
            });

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Generate_ShouldHaveErrorIfNoPairs()
        {
            // Arrange
            List<string> expected = new List<string>()
            {
                "Please add values for your number and word pairs"
            };

            // Act
            List<string> actual = new List<string>();

            FizzBuzz.Generate(15, new List<Tuple<int, string>>(), value =>
            {
                actual.Add(value);
            });

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
