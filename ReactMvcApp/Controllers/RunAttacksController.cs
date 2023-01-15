using System;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunAttacksController : BaseController
    {
        private readonly IRunAttackService _runAttackService;

        public RunAttacksController(IRunAttackService runAttackService)
        {
            _runAttackService = runAttackService;
        }

        [HttpGet("runNmap")]
        public ActionResult RunNmap(int userId, string ipAddress)
        {
            try
            {
                _runAttackService.RunNmap(userId, ipAddress);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("runTokenImpersonation")]
        public ActionResult RunTokenImpersonation(int userId)
        {
            try
            {
                _runAttackService.RunTokenImpersonation(userId);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
