using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEQueue.Tests
{
    [TestClass()]
    public class DEQueueTests
    {
        [TestMethod()]
        public void pushBackTest_KostyaAndMark_MarkReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushFront("Kostya");
            queue.pushBack("Mark");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void pushFrontTest_KostyaAndMark_MarkReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Kostya");
            queue.pushFront("Mark");

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popFrontTest_KostyaAndMark_MarkReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Kostya");
            queue.pushFront("Mark");
            queue.pushFront("Kate");
            queue.popFront();

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popBackTest_KostyaAndMark_KostyaReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Kostya";

            // act
            queue.pushBack("Kostya");
            queue.pushBack("Mark");
            queue.pushFront("Kate");
            queue.popBack();

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void ClearTes_KostyaAndMark_KostyaReturnt()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Kostya";

            // act
            queue.pushBack("Mark");
            queue.Clear();

            queue.pushBack("Kostya");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

    }
}