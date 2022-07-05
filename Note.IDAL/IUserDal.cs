using System;
using System.Collections.Generic;
using Note.Model;

namespace Note.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();

        User GetUser(int userNo);
    }
}