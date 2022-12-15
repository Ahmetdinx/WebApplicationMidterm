using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RunAttackManager : IRunAttackService
    {
        private readonly IAttackDetailsService _attackDetailsService;

        public RunAttackManager(IAttackDetailsService attackDetailsService)
        {
            _attackDetailsService = attackDetailsService;
        }

        [SecuredOperation("admin")]
        public IResult RunNmap(int userId)
        {
            string strCmdText;
            strCmdText = "nmap 192.168.1.1 -oX xml.file";
            Process.Start("cmd.exe", strCmdText);

            return AddDetails(userId, "Nmap");
        }

        public IResult AddDetails(int userId,string attackType)
        {
            var attackDetails = new AttackDetails()
            {
                AttackType = attackType,
                AttackDescription = File.ReadAllText("FILE PATH HERE"),
                Date    = DateTime.Now,
                UserId = userId
            };

            var result  = _attackDetailsService.Add(attackDetails);

            if (result.Success)
            {
                return new SuccessResult(attackDetails.AttackDescription);
            }

            return new ErrorResult(Messages.AttackCannotLogged);

        }
    }
}
