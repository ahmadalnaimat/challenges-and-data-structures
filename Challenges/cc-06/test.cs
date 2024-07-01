using System;
using Xunit;
using System.Collections.Generic;
using CommonElement;

namespace CommonElement.Tests
{
    public class CommonElementTests
    {
        [Fact]
        public void CommonElement_TestCase1()
        {
            // Arrange
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };

            // Act
            int[] result = CommonElement.CommonElements(array1, array2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CommonElement_TestCase2()
        {
            // Arrange
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            // Act
            int[] result = CommonElement.CommonElements(array1, array2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
