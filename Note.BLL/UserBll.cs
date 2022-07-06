using System;
using System.Collections.Generic;
using Note.IDAL;
using Note.Model;

namespace Note.BLL
{
    public class UserBll
    {
        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userNo)
        {
            return _userDal.GetUser(userNo);
        }
    }
}