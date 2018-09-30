using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exercicio_3.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ConvertController : ControllerBase
  {
    private services.IConvert _convert;

    public ConvertController(services.IConvert convert)
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
