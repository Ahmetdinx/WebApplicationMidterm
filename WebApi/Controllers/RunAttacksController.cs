using System;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunAttacksController : ControllerBase
    {
        private readonly IRunAttackService _runAttackService;

        public RunAttacksController(IRunAttackService runAttackService)
        {
            _runAttackService = runAttackService;
        }

        [HttpGet("runNmap")]
        public ActionResult RunNmap()
        {
            try
            {
                //_runAttackService.RunNmap();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
