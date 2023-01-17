using System;
using System.Net;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReactMvcApp.Controllers
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
            var result = _runAttackService.RunNmap(userId, ipAddress);
            if(result.Success)    
                return Ok(result.Message);
                
            return BadRequest(result.Message);
            
        }

        [HttpGet("runTokenImpersonation")]
        public ActionResult RunTokenImpersonation(int userId)
        {
            var result = _runAttackService.RunTokenImpersonation(userId);
            if (result.Success)
                return Ok(result.Message);

            return BadRequest(result.Message);
        }
    }
}
