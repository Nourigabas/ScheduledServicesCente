﻿using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_User
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User GetUser(Guid UserId);

        void DeleteUser(Guid UserId);

        void CreateUser(User User);

        void UpdateUser(Guid UserId, JsonPatchDocument<UserForCreate_Update> PatchDocument);
    }
}