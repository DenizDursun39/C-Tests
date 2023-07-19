using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_userDal.Get(p=>p.Id == id));
        }

        public IDataResult<Users> GetUserByEmail(string email)
        {
            return new SuccessDataResult<Users>(_userDal.Get(p => p.Email.Equals(email)));
        }

        public IDataResult<List<UserDetailsDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailsDto>>(_userDal.GetUserDetails());
        }

        public IDataResult<List<Users>> GetUsersByName(string firstName)
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(p=>p.FirstName == firstName));
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
