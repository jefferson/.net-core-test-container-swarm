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
  public class HealthController : ControllerBase
  {

    private IHealth _health;

    public HealthController(IHealth health)
    {
      _health = health;
    }

    [HttpGet()]
    public ActionResult<string> pressure()
    {
      var sistolica = (new Random()).Next(1, 130);
      var diastolica = (new Random()).Next(1, 130);

      return _health.pressure(sistolica, diastolica);

    }

  }
}
