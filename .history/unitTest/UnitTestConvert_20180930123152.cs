using System;
using Xunit;
using exercicio_3.services;

namespace unitTest
{
  public class UnitTestConvert
  {
    private readonly ConvertTemperature _convert;

    public UnitTestConvert()
    {
      _convert = new ConvertTemperature();
    }

    [Fact]
    public void TestIntValues()
    {

      Assert.Equal(113, _convert.CelsiusToFahrenheit(45));
      Assert.Equal(32, _convert.CelsiusToFahrenheit(0));
      Assert.Equal(77, _convert.CelsiusToFahrenheit(25));
      Assert.Equal(95, _convert.CelsiusToFahrenheit(35));

    }

    [Fact]
    public void TestDoubleValues()
    {
      Assert.Equal(113, _convert.CelsiusToFahrenheit(45));
      Assert.Equal(32, _convert.CelsiusToFahrenheit(0));
      Assert.Equal(77, _convert.CelsiusToFahrenheit(25));
      Assert.Equal(95, _convert.CelsiusToFahrenheit(35));
    }
  }
}