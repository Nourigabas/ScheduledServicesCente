using Domain.Authentication;

namespace Data.Repository.RepositoryModels.M_Account
{
    public interface IAccountRepository
    {
        (bool, string, string) Login(AuthRequest auth, bool IsOwner);
    }
}