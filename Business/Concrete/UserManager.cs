using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService        

    {
        IUserDal _userDal;
        IUserService _userService;
        public UserManager(IUserDal userDal , IUserService userService)
        {
            _userDal = userDal;
            _userService = userService;
        }

       
        public IDataResult<User> GetById(int id)
        {
                return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }
        

        public IDataResult<User> Login(UserForLoginDto user)
        {
            
            var result = _userDal.Get(u => u.Email == user.EMail);
            if (result == null)
            {
                return new ErrorDataResult<User>("UserNotFound");
            }
            bool isVerified = HashingHelper.VerifyPasswordHash(user.Password, result.PasswordHash, result.PasswordSalt);
            if (isVerified)
            {
                return new SuccessDataResult<User>(result,"Login Succesful");
            }
            return new ErrorDataResult<User>("Login Error");
        }

        public IDataResult<User> Register(UserForRegisterDto user)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);
            var result = new User
            {
                Email = user.EMail,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userDal.Add(result);
            return new SuccessDataResult<User>(result , "Succes register");
        }

        public IDataResult<User> Update(UserForUpdateDto user)
        {
            var result = _userDal.Get(u => u.Email == user.Email);
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);
            if (result == null)
            {
                return new ErrorDataResult<User>("UserNotFound");
            }
            if (!HashingHelper.VerifyPasswordHash(user.PasswordToCheck, result.PasswordHash, result.PasswordSalt))
            {
                return new ErrorDataResult<User>("Wrong password");
            }
            result.Email = user.Email;
            result.FirstName = user.FirstName;
            result.LastName = user.LastName;
            result.PasswordHash = passwordHash;
            result.PasswordSalt = passwordSalt;
            result.Status = true;

            _userDal.Update(result);
            return new SuccessDataResult<User>(result, "Succesful update");
        }
    }
}
