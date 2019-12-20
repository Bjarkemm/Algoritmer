using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmeButik;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGdicAddDublicate()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            testDic.Add("Horse", 309);
            

            //Arrange

            //Assert

        }

        [TestMethod]
        public void TestGdicFindWithKey()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            int expected = 36;

            //Arrange
            int actual = testDic["Cat"];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGdicFindWithValue()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            string expected = "Human";

            //Arrange
            string actual = testDic[-13];

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestGdicCount()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            int expected = 5;

            //Arrange
            int actual = testDic.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestGdicContainsKeyTrue()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            bool expected = true;

            //Arrange
            bool actual = testDic.ContainsKey("Dog");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGdicContainsKeyFalse()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            bool expected = false;

            //Arrange
            bool actual = testDic.ContainsKey("Bird");

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestGdicContainsValueTrue()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            bool expected = true;

            //Arrange
            bool actual = testDic.ContainsValue(256);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGdicContainsValueFalse()
        {
            //Act 
            Gdictionary<string, int> testDic = new Gdictionary<string, int>();
            testDic.Add("Dog", 1);
            testDic.Add("Cat", 36);
            testDic.Add("Mouse", 0);
            testDic.Add("Human", -13);
            testDic.Add("Horse", 256);

            bool expected = false;

            //Arrange
            bool actual = testDic.ContainsValue(99);

            //Assert
            Assert.AreEqual(expected, actual);

        }




    }
}
