using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAttackDetailsService 
    {
        IDataResult<AttackDetails> GetById(int id);
        IDataResult<List<AttackDetails>> GetAll();
    }
}
