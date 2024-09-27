using Domain.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_Account
{
    public interface IAccountRepository
    {
        (bool, string , string) Login(AuthRequest auth, bool IsOwner);
    }
}
