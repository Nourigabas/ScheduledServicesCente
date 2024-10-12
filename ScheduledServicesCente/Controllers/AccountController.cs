using Data.Repository.RepositoryModels.M_Account;
using Domain.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ScheduledServicesCente.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[Controller]")]
    public class AccountController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IAccountRepository Account;

        public AccountController(IConfiguration configuration, IAccountRepository Account)
        {
            this.configuration = configuration;
            this.Account = Account;
        }

        //فحص معلومات المستخدم وجلب
        //token
        [HttpGet("Authentication")]
        public ActionResult<string> LoginAccount(AuthRequest Request, bool IsOwner)
        {
            (var res, var stringfortype, var fullname) = Account.Login(Request, IsOwner);
            if (res is false && stringfortype == "IsNotUserOrOwner")
                return Unauthorized();

            var Claims = new List<Claim>();
            Claims.Add(new Claim(ClaimTypes.GivenName, fullname));
            Claims.Add(new Claim("TypeAccount", res ? "Owner" : "User"));
            var SecretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Authentication:SecretKey"]));
            var SigningCred = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);
            var SecurityToken = new JwtSecurityToken
            (
            configuration["Authentication:Issuer"],
            configuration["Authentication:Audience"],
            Claims,
            DateTime.UtcNow,
            DateTime.UtcNow.AddDays(1),
            SigningCred
            );
            var Token = new JwtSecurityTokenHandler().WriteToken(SecurityToken);
            return Ok(new
            {
                Token,
                AccountType = res ? "Owner" : "User"
            });
        }
    }
}