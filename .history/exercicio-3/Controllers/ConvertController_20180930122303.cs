using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_3.services;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_3.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ConvertController : ControllerBase
  {

    private IConvertTemperature _convert;

    public ConvertController(IConvertTemperature convert)
    {
      _convert = convert;
    }

    [HttpGet("fahrenheit/{celsius}")]
    public ActionResult<double> fahrenheit(double celsius)
    {
      return _convert.CelsiusToFahrenheit(celsius);
    }

  }
}
