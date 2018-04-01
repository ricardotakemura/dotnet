using System;
using System.Collections.Generic;
using Questao2.Models;

namespace Questao2.Business
{
    public interface IUserBusiness: IBusiness
    {
        List<User> GetUsersWithSalesOrder();
        User GetUser(int userId);
        void InsertUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
