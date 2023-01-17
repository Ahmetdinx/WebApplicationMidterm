using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business.Abstract;

namespace ReactMvcApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttackDetailsController : BaseController
    {
        private IAttackDetailsService _attackDetailsService;

        public AttackDetailsController(IAttackDetailsService attackDetailsService)
        {
            _attackDetailsService = attackDetailsService;
        }

        [HttpGet("getAll")]
        public ActionResult GetAll()
        {
            var result = _attackDetailsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getAllByAttackType")]
        public ActionResult GetAllByAttackType(string email, string attackType)
        {
            var result = _attackDetailsService.GetAllByEmailAndAttackType(email,attackType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getById")]
        public ActionResult GetById(int id)
        {
            var result = _attackDetailsService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        
        [HttpGet("getByEmail")]
        public ActionResult GetByEmail(string email)
        {
            var result = _attackDetailsService.GetAllByEmail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        

        [HttpPost("add")]
        public IActionResult Add(AttackDetails attackDetails)
        {
            var result = _attackDetailsService.Add(attackDetails);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);


        }


        [HttpPost("update")]
        public IActionResult Update(AttackDetails attackDetails)
        {
            var result = _attackDetailsService.Update(attackDetails);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);


        }


        [HttpPost("delete")]
        public IActionResult Delete(AttackDetails attackDetails)
        {
            var result = _attackDetailsService.Delete(attackDetails);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);


        }

    }
}
