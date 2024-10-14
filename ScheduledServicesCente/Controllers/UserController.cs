using AutoMapper;
using Data.Repository.RepositoryModels.M_User;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ScheduledServicesCente.Controllers
{
    [AllowAnonymous]

    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository User;
        private readonly IMapper mapper;
        public UserController(IUserRepository User, IMapper mapper)
        {
            this.User = User;
            this.mapper = mapper;
        }

        //[AllowAnonymous]
        [HttpGet]
        [Route("users")]
        public ActionResult<List<User>> GetUsers()
        {
            var respone = User.GetUsers();
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpGet]
        [Route("user/{UserId}")]
        public ActionResult<User> GetSector(Guid UserId)
        {
            var respone = User.GetUser(UserId);
            if (respone == null)
                return NotFound();
            return Ok(respone);
        }

        [HttpPost]
        [Route("user/create")]
        public ActionResult CreateUser(UserForCreate_Update user)
        {
            var UserForCreate = mapper.Map<User>(user);
            User.CreateUser(UserForCreate);
            return Ok();
        }

        [HttpDelete]
        [Route("user/delete/{UserId}")]
        public ActionResult DeleteUser(Guid UserId)
        {
            var Check = User.GetUser(UserId);
            if (Check == null)
                return NotFound();
            User.DeleteUser(UserId);
            return Ok();
        }
        [HttpPatch]
        [Route("user/update/{UserId}")]
        public ActionResult<User> UpdateUser(Guid UserId, JsonPatchDocument<UserForCreate_Update> PatchDocument)
        {
            var Check = User.GetUser(UserId);
            if (Check == null)
                return NotFound();
            User.UpdateUser(UserId, PatchDocument);
            return NoContent();
        }
    }
}