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
        IDataResult<List<User>> GetAllUsers();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetById(int id);
        IDataResult<User> Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
