using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> Login(UserForLoginDto user);
        IDataResult<User> Register(UserForRegisterDto user);
        IDataResult< User> GetById(int id);
        IDataResult<User> Update(UserForUpdateDto user);
    }
}
