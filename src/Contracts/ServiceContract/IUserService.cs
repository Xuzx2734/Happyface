using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.ServiceContract
{
    public interface IUserService
    {
        UsersModel GetUserByAccount(string userAccount);

        IEnumerable<UsersModel> GetAllUsers();

        void AddUser();
    }
}
