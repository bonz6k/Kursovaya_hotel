using System;
using Xunit;
using KURSOVAYA_progect.V1;
using System.Data.OleDb;
using System.Data;

namespace KURSOVAYA_Tests
{
    public class KURSOVAYA_test
    {
        [Fact]
        public void adding_test_Form1()
        {
            //arrange
            Form1 f1 = new Form1();
            int expected;
            int actual;

            //act
            expected = f1.Expected(); 

            //assert
        }
    }
}
