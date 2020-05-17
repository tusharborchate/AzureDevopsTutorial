using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController valuesController =new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            List<WeatherForecast> returnValue = valuesController.Get().ToList();
            Assert.Equal(5, returnValue.Count);
        }
    }
}
