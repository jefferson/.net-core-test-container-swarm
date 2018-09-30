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

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void Test1()
    {

    }
  }
}
