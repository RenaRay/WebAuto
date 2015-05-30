using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAuto.Models;

namespace WebAuto.Data
{
    public interface IUsersRepository
    {
        void Create(UserModel user);
        List<UserModel> GetAll();
    }
}