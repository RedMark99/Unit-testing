using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyIntLibrary.Test
{
    [TestClass]
    public class MyIntTest
    {
        [TestMethod]
        public void add_10and20_30returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(20);
            int expected = 30;

            // act

            MyInt actual = x.add(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void add_5and5_10returnnedByte()
        {
            // arrange
            MyInt x = new MyInt(0b101);
            MyInt y = new MyInt(0b101);
            int expected = 10;

            // act

            MyInt actual = x.add(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void subtract_30and20_10returnned()
        {
            // arrange
            MyInt x = new MyInt(30);
            MyInt y = new MyInt(20);
            int expected = 10;

            // act

            MyInt actual = x.subtract(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void multiply_2and5_10returnned()
        {
            // arrange
            MyInt x = new MyInt(2);
            MyInt y = new MyInt(5);
            int expected = 10;

            // act

            MyInt actual = x.multiply(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void divide_10and5_2returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(5);
            int expected = 2;

            // act

            MyInt actual = x.divide(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void max_10and5_2returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(5);
            int expected = 10;

            // act

            MyInt actual = x.max(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void min_10and5_2returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(5);
            int expected = 5;

            // act

            MyInt actual = x.min(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void abs_5return()
        {
            // arrange
            MyInt x = new MyInt(-5);
            int expected = 5;

            // act

            MyInt actual = x.abs();

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }

        [TestMethod]
        public void CompareTo_5and5_true_returned()
        {
            // arrange
            MyInt x = new MyInt(5);
            MyInt y = new MyInt(5);
            Boolean expected = true;

            // act

            MyInt actual = x.compareTo(y);

            // assert
            Assert.AreEqual(expected, Convert.ToBoolean(actual.num.ToString()));
        }

        [TestMethod]
        public void gcd_9and3_3returned()
        {
            // arrange
            MyInt x = new MyInt(9);
            MyInt y = new MyInt(3);
            int expected = 3;

            // act

            MyInt actual = x.gcd(y);

            // assert
            Assert.AreEqual(expected, int.Parse(actual.num.ToString()));
        }
    }
}