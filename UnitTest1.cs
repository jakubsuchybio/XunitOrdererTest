using System;
using System.Diagnostics;
using System.Threading;
using Xunit;
using XUnitPriorityOrderer;

namespace XunitOrdererTest
{
    [Order(1)]
    public class TestClass1 : PriorityBaseClass
    {
        [Fact]
        [Order(1)]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(1);
        }

        [Fact]
        [Order(2)]
        public void TestMethod2()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(2);
        }
    }

    [Order(2)]
    public class TestClass2 : PriorityBaseClass
    {
        [Fact]
        [Order(3)]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(3);
        }

        [Fact]
        [Order(4)]
        public void TestMethod2()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(4);
        }
    }

    [Order(3)]
    public class TestClass3 : PriorityBaseClass
    {
        [Fact]
        [Order(5)]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(3);
        }

        [Fact]
        [Order(6)]
        public void TestMethod2()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(4);
        }
    }

    [Order(4)]
    public class TestClass4 : PriorityBaseClass
    {
        [Fact]
        [Order(7)]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(3);
        }

        [Fact]
        [Order(8)]
        public void TestMethod2()
        {
            Thread.Sleep(1000);
            Debug.WriteLine(4);
        }
    }
}
