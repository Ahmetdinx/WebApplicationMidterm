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
using static System.Net.Mime.MediaTypeNames;

namespace Business.Concrete
{
    public class RunAttackManager : IRunAttackService
    {
        private readonly IAttackDetailsService _attackDetailsService;

        public RunAttackManager(IAttackDetailsService attackDetailsService)
        {
            _attackDetailsService = attackDetailsService;
        }


        public IResult RunNmap(int userId, string ipAddress)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "nmap -oN nmap_test_result.txt 127.0.0.1";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Windows\SysWOW64";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(proc1);

            string testResult1 = File.ReadAllText(@"C:\Windows\SysWOW64\nmap_test_result.txt");
            return AddDetails(userId, "nmap", testResult1);
        }

        public IResult AddDetails(int userId,string attackType, string attackDescription)
        {
            var attackDetails = new AttackDetails()
            {
                AttackType = attackType,
                AttackDescription = attackDescription,
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

        public IResult RunTokenImpersonation(int userId)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "privilege::debug log token::elevate exit";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\Users\Melih\Documents\GitHub\WebApplicationMidterm\WebApi\wwwroot\mimikatz-master\x64";
            proc1.FileName = @"C:\Users\Melih\Documents\GitHub\WebApplicationMidterm\WebApi\wwwroot\mimikatz-master\x64\mimikatz.exe";
            proc1.Verb = "runas";
            proc1.Arguments = anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Normal;

            Process process1 = Process.Start(proc1);
            process1.WaitForExit();

            string testResult1 =
                File.ReadAllText(
                    @"C:\Users\Melih\Documents\GitHub\WebApplicationMidterm\WebApi\wwwroot\mimikatz-master\x64\mimikatz.log");
            var result = AddDetails(userId, "Token Impersonation", testResult1);

            File.WriteAllText(@"C:\Users\Melih\Documents\GitHub\WebApplicationMidterm\WebApi\wwwroot\mimikatz-master\x64\mimikatz.log", String.Empty);
            return result;
        }
    }
}
