using System;
using Xunit;
using exercicio_3.services;

namespace unitTest
{
  public class HealthTest
  {
    private readonly CheckHealth check;

    public HealthTest()
    {
      check = new CheckHealth();
    }

    [Fact]
    public void TestPressure()
    {
      Assert.Equal("PRESSÃO ARTERIAL NORMAL", check.pressure(120, 80));
      Assert.Equal("PRÉ-HIPERTENSÃO", check.pressure(120, 129));
      Assert.Equal("HIPERTENSÃO ESTÁGIO 1", check.pressure(130, 139));
      Assert.Equal("HIPERTENSÃO ESTÁGIO 2", check.pressure(140, 90));
      Assert.Equal("CRISE HIPERTENSIVA", check.pressure(181, 150));
    }

  }
}
