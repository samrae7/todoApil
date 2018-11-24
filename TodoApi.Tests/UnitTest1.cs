using System;
using Xunit;
using TodoApi.Controllers;

namespace TodoApi.Tests
{
    public class TodoApi_ValuesControllerShould
    {
        private readonly ValuesController _valuesController;

        public TodoApi_ValuesControllerShould()
        {
            _valuesController = new ValuesController();
        }
        [Fact]
        public void ReturnValues()
        {
            var actualResult = _valuesController.Get().Value;
            var expectedResult = new string[] { "value1", "value2" };

            Assert.Equal(actualResult, expectedResult);
        }
    }
}
