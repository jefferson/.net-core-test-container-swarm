using System;

namespace exercicio_3.services
{
  public class CheckHealth : IHealth
  {
    public string pressure(double sistolica, double diastolica)
    {
      if (sistolica <= 120 && diastolica <= 80)
        return "PRESSÃO ARTERIAL NORMAL";

      if ((sistolica >= 120 && sistolica <= 129) || diastolica <= 80)
        return "PRÉ-HIPERTENSÃO";

      if ((sistolica >= 130 && sistolica <= 139) || (diastolica >= 80 && diastolica <= 89))
        return "HIPERTENSÃO ESTÁGIO 1";

      if ((sistolica >= 140 && sistolica < 180) && (diastolica >= 90 && diastolica < 110))
        return "HIPERTENSÃO ESTÁGIO 2";

      if (sistolica >= 180 && diastolica >= 110)
        return "CRISE HIPERTENSIVA";

      return string.Empty;
    }

  }
}