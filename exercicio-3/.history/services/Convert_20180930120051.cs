namespace exercicio_3.services
{
  public class Convert : IConvert
  {
    public double fahrenheitToCelsius(double celsius)
    {
      return celsius * 1.8000 + 32;
    }
  }
}