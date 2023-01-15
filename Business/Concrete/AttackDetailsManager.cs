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
        private readonly IAttackDetailsDal _attackDetailsDal;
        private readonly IUserService _userService;

        public AttackDetailsManager(IAttackDetailsDal attackDetailsDal, IUserService userService)
        {
            _attackDetailsDal = attackDetailsDal;
            _userService = userService;
        }

        public IDataResult<List<AttackDetails>> GetAllByEmail(string email)
        {
            var attackedUser = _userService.GetByMail(email);
            return new SuccessDataResult<List<AttackDetails>>(
                _attackDetailsDal.GetAll(a => a.Id == attackedUser.Data.Id));
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
