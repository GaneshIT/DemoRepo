using EmployeeBonus;
using Moq;
using NUnit.Framework;
using System;
using Xunit;
//Moq
namespace MyTestProject
{
    public class TestClassMyOperation
    {
        [SetUp]
        public void beforetest()
        {
            var a = 10;
            var b = 20;
            Console.WriteLine("Before");
        }

        [TearDown]
        public void AfterTest()
        {
            var a = 0;
            var b = 0;
            Console.WriteLine("After");
        }


        //[Fact] //Attribute
        //public void Test_Addition()
        //{
        //    var a = 10;
        //    var b= 20;
        //    var result= MyOperations.add(a, b);
        //    Assert.Equal(30,result);
        //}
        //[Fact]
        //public void Test_Subtraction()
        //{
        //    var a = 20;
        //    var b = 10;
        //    var result = MyOperations.sub(a, b);
        //    Assert.Equal(10, result);
        //}

        [Fact]
        public void TestAddition()
        {
            var myoperation = new Mock<IOperations>();
            myoperation.Setup(obj => obj.add(2, 4)).Returns(6);//setup... fakedata, tempdata
            Xunit.Assert.Equal(6, myoperation.Object.add(2, 4));
        }
    }
}
