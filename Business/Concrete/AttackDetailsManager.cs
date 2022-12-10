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

        public AttackDetailsManager(IAttackDetailsDal attackDetailsDal)
        {
            _attackDetailsDal = attackDetailsDal;
        }

        public IResult Add(AttackDetails attackDetails)
        {
            _attackDetailsDal.Add(attackDetails);
            return new SuccessResult("Attack logged to the system");
        }

        public IResult Delete(AttackDetails attackDetails)
        {
            _attackDetailsDal.Delete(attackDetails);
            return new SuccessResult("Attack deleted from the system");
        }

        public IDataResult<List<AttackDetails>> GetAll()
        {
            return new SuccessDataResult<List<AttackDetails>>(_attackDetailsDal.GetAll());
        }

        public IDataResult<AttackDetails> GetById(int attackId)
        {
            return new SuccessDataResult<AttackDetails>(_attackDetailsDal.Get(a => a.Id == attackId));
        }

        public IResult Update(AttackDetails attackDetails)
        {
            _attackDetailsDal.Update(attackDetails);
            return new SuccessResult("Attack updated");
        }
    }
}
