using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgoTestProject_1
{
    [TestClass]
    public class AlgoTest_1
    {

        // Добавление и поиск одного значения
        //
        [TestMethod]
        public void TestBit_1()
        {
            BloomFilter filter = new BloomFilter(32);
            filter.Add("floor");
            Assert.AreEqual(true, filter.IsValue("floor"));
        }

        // Добавление и поиск 8и значений
        //
        [TestMethod]
        public void TestBit_2()
        {
            BloomFilter filter = new BloomFilter(32);
            filter.Add("floor");
            filter.Add("ground");
            filter.Add("ceil");
            filter.Add("top");
            filter.Add("wall");
            filter.Add("door");
            filter.Add("window");
            filter.Add("hedge");
            Assert.AreEqual(true, filter.IsValue("floor"));
            Assert.AreEqual(true, filter.IsValue("floor"));
            Assert.AreEqual(true, filter.IsValue("ground"));
            Assert.AreEqual(true, filter.IsValue("ceil"));
            Assert.AreEqual(true, filter.IsValue("top"));
            Assert.AreEqual(true, filter.IsValue("wall"));
            Assert.AreEqual(true, filter.IsValue("door"));
            Assert.AreEqual(true, filter.IsValue("window"));
            Assert.AreEqual(true, filter.IsValue("hedge"));
        }

        // Добавление и поиск 32 значений
        //
        [TestMethod]
        public void TestBit_3()
        {
            BloomFilter filter = new BloomFilter(32);
            filter.Add("floor");
            filter.Add("ground");
            filter.Add("ceil");
            filter.Add("top");
            filter.Add("wall");
            filter.Add("door");
            filter.Add("window");
            filter.Add("hedge");

            filter.Add("flower");
            filter.Add("tree");
            filter.Add("leaf");
            filter.Add("wood");
            filter.Add("forest");
            filter.Add("grass");
            filter.Add("dirt");
            filter.Add("water");

            filter.Add("building");
            filter.Add("castle");
            filter.Add("bastion");
            filter.Add("city");
            filter.Add("town");
            filter.Add("road");
            filter.Add("banner");
            filter.Add("sign");

            filter.Add("worm");
            filter.Add("butterfly");
            filter.Add("fly");
            filter.Add("ant");
            filter.Add("bug");
            filter.Add("mosquito");
            filter.Add("bee");
            filter.Add("wasp");

            Assert.AreEqual(true, filter.IsValue("floor"));
            Assert.AreEqual(true, filter.IsValue("ground"));
            Assert.AreEqual(true, filter.IsValue("ceil"));
            Assert.AreEqual(true, filter.IsValue("top"));
            Assert.AreEqual(true, filter.IsValue("wall"));
            Assert.AreEqual(true, filter.IsValue("door"));
            Assert.AreEqual(true, filter.IsValue("window"));
            Assert.AreEqual(true, filter.IsValue("hedge"));
            
            Assert.AreEqual(true, filter.IsValue("flower"));
            Assert.AreEqual(true, filter.IsValue("tree"));
            Assert.AreEqual(true, filter.IsValue("leaf"));
            Assert.AreEqual(true, filter.IsValue("wood"));
            Assert.AreEqual(true, filter.IsValue("forest"));
            Assert.AreEqual(true, filter.IsValue("grass"));
            Assert.AreEqual(true, filter.IsValue("dirt"));
            Assert.AreEqual(true, filter.IsValue("water"));
            
            Assert.AreEqual(true, filter.IsValue("building"));
            Assert.AreEqual(true, filter.IsValue("castle"));
            Assert.AreEqual(true, filter.IsValue("bastion"));
            Assert.AreEqual(true, filter.IsValue("city"));
            Assert.AreEqual(true, filter.IsValue("town"));
            Assert.AreEqual(true, filter.IsValue("road"));
            Assert.AreEqual(true, filter.IsValue("banner"));
            Assert.AreEqual(true, filter.IsValue("sign"));
            
            Assert.AreEqual(true, filter.IsValue("worm"));
            Assert.AreEqual(true, filter.IsValue("butterfly"));
            Assert.AreEqual(true, filter.IsValue("fly"));
            Assert.AreEqual(true, filter.IsValue("ant"));
            Assert.AreEqual(true, filter.IsValue("bug"));
            Assert.AreEqual(true, filter.IsValue("mosquito"));
            Assert.AreEqual(true, filter.IsValue("bee"));
            Assert.AreEqual(true, filter.IsValue("wasp"));
        }
        

        // Добавление строки с числовыми символами от 0 до 9 в разном порядке 10 раз.
        //
        [TestMethod]
        public void TestBit_4()
        {
            BloomFilter filter = new BloomFilter(32);
            filter.Add("0123456789");
            filter.Add("1234567890");
            filter.Add("2345678901");
            filter.Add("3456789012");
            filter.Add("4567890123");
            filter.Add("5678901234");
            filter.Add("6789012345");
            filter.Add("7890123456");
            filter.Add("8901234567");
            filter.Add("9012345678");

            Assert.AreEqual(true, filter.IsValue("0123456789"));
            Assert.AreEqual(true, filter.IsValue("1234567890"));
            Assert.AreEqual(true, filter.IsValue("2345678901"));
            Assert.AreEqual(true, filter.IsValue("3456789012"));
            Assert.AreEqual(true, filter.IsValue("4567890123"));
            Assert.AreEqual(true, filter.IsValue("5678901234"));
            Assert.AreEqual(true, filter.IsValue("6789012345"));
            Assert.AreEqual(true, filter.IsValue("7890123456"));
            Assert.AreEqual(true, filter.IsValue("8901234567"));
            Assert.AreEqual(true, filter.IsValue("9012345678"));
        }


        // Добавление пустой строки
        //
        [TestMethod]
        public void TestBit_5()
        {
            BloomFilter filter = new BloomFilter(32);

            Assert.AreEqual(false, filter.IsValue(""));

            filter.Add("");
            Assert.AreEqual(true, filter.IsValue(""));
        }
    }
}
