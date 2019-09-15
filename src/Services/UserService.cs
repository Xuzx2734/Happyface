using Contracts;
using Entities.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;
using Contracts.ServiceContract;

namespace Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repoWrapper;
        private RepositoryContext _db;

        public UserService(IRepositoryWrapper repoWrapper, RepositoryContext db)
        {
            _repoWrapper = repoWrapper;
            _db = db;
        }

        public IEnumerable<UsersModel> GetAllUsers()
        {
            var users =  _db.Users.ToList();
            var user = (from x in _db.Users
                        where x.userid_ == 1
                        select x).FirstOrDefault();
            return users;
        }

        public UsersModel GetUserByAccount(string userAccount)
        {
            //System.Runtime.Serialization.Json
            throw new NotImplementedException();
        }

        public void AddUser()
        {
            ///测试例子
            var user = new UsersModel()
            {
                userid_ = new Random().Next(0,100),
                code_ = "111",
                delflag_ = 0,
                idate_ = DateTime.Now,
                name_ = "test",
                pass_ = "123456",
                udate_ = DateTime.Now
            };

            _db.Users.Add(user);
            var count = _db.SaveChanges();

            var dbUser = _db.Users.Where(x => x.userid_ == 1).First();
            dbUser.pass_ = "123456";
            _db.Users.Update(dbUser);

            count += _db.SaveChanges();
            
        }
        
    }
}
