using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TAP_TEST.Application.CardPrefix.Queries.GetDetailByPrefix;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeApiController : BaseController
    {
        [HttpGet("{prefix}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CardPrefixDto>> Get(string prefix)
        {
                return Ok(await Mediator.Send(new GetDetailByPrefixQuery { prefix = prefix }));  
        }
    }
}
