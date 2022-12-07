using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AttackDetailsManager : IAttackDetailsService
    {
        IAttackDetailsService _attackDetailsService;
        IAttackDetailsDal _attackDetailsDal;

        public AttackDetailsManager(IAttackDetailsService attackDetailsService , IAttackDetailsDal attackDetailsDal)
        {
            _attackDetailsService = attackDetailsService;
            _attackDetailsDal = attackDetailsDal;
        }

        public IDataResult<List<AttackDetails>> GetAll()
        {
            return new SuccessDataResult<List<AttackDetails>>(_attackDetailsDal.GetAll());
        }

        public IDataResult<AttackDetails> GetById(int attackId)
        {
            return new SuccessDataResult<AttackDetails>(_attackDetailsDal.Get(a => a.AttackId == attackId));
        }
    }
}
