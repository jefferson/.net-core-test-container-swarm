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
      Assert.Equal(1132, _convert.CelsiusToFahrenheit(45));
    }

    [Fact]
    public void TestDoubleValues()
    {

    }
  }
}
