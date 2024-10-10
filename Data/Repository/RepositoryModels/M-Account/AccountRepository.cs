using Domain.Authentication;

namespace Data.Repository.RepositoryModels.M_Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DatabaseContext DatabaseContext;

        public AccountRepository(DatabaseContext DatabaseContext)
        {
            this.DatabaseContext = DatabaseContext;
        }

        public (bool, string, string) Login(AuthRequest Request, bool IsOwner)
        {
            if (IsOwner)
            {
                var OwnerAccont = DatabaseContext.OwnerServices.Where(req =>
                                                                    req.UserName == Request.Username
                                                                    &&
                                                                    req.Password == Request.Password).FirstOrDefault();
                if (OwnerAccont is not null)
                    return (true, "IsOwnre", OwnerAccont.FullName);
            }

            var UserAccont = DatabaseContext.Users.Where(req =>
                                                            req.UserName == Request.Username
                                                            &&
                                                            req.Password == Request.Password).FirstOrDefault();
            if (UserAccont is not null)
                return (false, "IsUser", UserAccont.FullName);
            return (false, "IsNotUserOrOwner", "");
        }
    }
}