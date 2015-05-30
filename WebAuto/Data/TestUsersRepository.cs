using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAuto.Models;

namespace WebAuto.Data
{
    public class TestUsersRepository: IUsersRepository
    {
        private List<UserModel> _users =
            new List<UserModel>();

        public TestUsersRepository()
        {
            Create(
                new UserModel
                {
                    Login="Renata",
                   Password="1234567",
                });                          
        }

        public void Create(UserModel user)
        {
            _users.Add(user);
        }

        public List<UserModel> GetAll()
        {
            return _users;
        }
    }
}