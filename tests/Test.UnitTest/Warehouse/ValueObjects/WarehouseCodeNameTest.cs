using Domain.Warehouse.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.UnitTest.Warehouse.ValueObjects
{
    public class WarehouseCodeNameTest
    {
        public static IEnumerable<object[]> WrongData =>
        new List<object[]>
        {
                new object[] { "ss???" },
                new object[] { "C-!" },
                new object[] { "22222222C-!cccccccccc" }
        };
        public static IEnumerable<object[]> CorrectData =>
        new List<object[]>
        {
                        new object[] { "AAA-123" },
                        new object[] { "123-BBB" }
        };


        [Theory]
        [MemberData(nameof(CorrectData))]
        public void WarehouseCodeName_Entries_IsValid(string codeName)
        {
            //Arrange and Act
            WarehouseCodeName methodUnderTest = new WarehouseCodeName(codeName);

            //Assert
            Assert.Equal(codeName, methodUnderTest.ToString());
        }


        [Theory]
        [MemberData(nameof(WrongData))]
        public void WarehouseCodeName_Is_InValid(string codeName)
        {

            // Act
            Exception exception = Assert.Throws<ArgumentException>(() =>
            {
                new WarehouseCodeName(codeName);
            });

            //Assert
            Assert.Contains("Input codeName was not in required format", exception.Message);
        }

        [Fact]
        public void WarehouseCodeName_Null_Is_Invalid()
        {
            //Arrange 
            string codeName = null;

            // Act
            Exception exception = Assert.Throws<ArgumentNullException>(() =>
            {
                new WarehouseCodeName(codeName);
            });

            //Assert
            Assert.Contains("Value cannot be null.", exception.Message);
        }


    }
}
