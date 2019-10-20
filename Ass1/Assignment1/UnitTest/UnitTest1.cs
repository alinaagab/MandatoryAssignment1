using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string V = "0123456789";

        [TestMethod]
        public void TestTitle()
        {
            //Arrange + Act
            Book book = new Book();

            //Assert
            Assert.ThrowsException<Exception>(() =>
            {
                string b = "ab";
                book.Title = b;
            });


        }
        [TestMethod]
        public void TestPageNumber()
        {
            //Arrange + Act
            Book book = new Book();

            //Assert
            Assert.ThrowsException<Exception>(() =>
            {
                int p = 123456789;
                book.PageNumber = p;
            });



        }
        [TestMethod]
        public void Test13()
        {
            //Arrange + Act
            Book book = new Book();

            //Assert
            Assert.ThrowsException<Exception>(() =>
            {
                string l = "qwertyuiopasdf";
                book.Isbn13 = l;

            });
        }
    }
}
