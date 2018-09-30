using System;

namespace exercicio_3.services
{
  public class ConvertTemperature : IConvertTemperature
  {
    public double CelsiusToFahrenheit(double celsius)
    {
      return Math.Round(celsius * 1.8000 + 32, 2);
    }
  }
}