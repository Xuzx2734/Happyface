﻿using Contracts;
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
        private CoreContext _db;

        public UserService(IRepositoryWrapper repoWrapper, CoreContext db)
        {
            _repoWrapper = repoWrapper;
            _db = db;
        }

        public FY_User GetUserByAccount(string userAccount)
        {
            //var query = from x in _db.FY_User.Where(x => x.UserAccount == userAccount)
            //            select x;
            //var user = query.FirstOrDefault();
            //return query.FirstOrDefault();

            return null;
        }

        public FY_User GetUserById(Guid userGuid)
        {
            //var query = from x in _db.FY_User.Where(x => x.UserId == userGuid)
            //            select x;

            //var user = query.FirstOrDefault();
            //return user;
            throw new NotImplementedException();
        }

        public IEnumerable<FY_User> GetAllUsers()
        {
            //var query = from x in _db.FY_User
            //            select x;

            //var list = query.ToList();

            //return list;
            throw new NotImplementedException();

        }

    }
}
