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
    private services.Convert convert;

    public ConvertController(services.IConvert _convert)
    {
      convert = _convert;
    }

    [HttpGet("fahrenheit/{celsius}")]
    public ActionResult<IEnumerable<string>> fahrenheit(double celsius)
    {

      return new string[] { "value1", celsius.ToString() };
    }

  }
}
