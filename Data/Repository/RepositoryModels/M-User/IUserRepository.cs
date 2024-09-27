using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_User
{
    public interface IUserRepository
    {
        List<User> GetUser();
        User GetUser(Guid UserId);
        void DeleteUser(Guid UserId);
        void CreateUser(User User);
        void UpdateUser(Guid UserId);
    }
}
