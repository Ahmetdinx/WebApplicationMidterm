using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IRunAttackService
    {
        public IResult RunNmap(int userId, string ipAddress);
        public IResult AddDetails(int userId, string attackType, string attackDescription);
        public IResult RunTokenImpersonation(int userId);
    }
}
