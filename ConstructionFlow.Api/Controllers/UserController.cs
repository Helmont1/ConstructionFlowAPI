﻿using ConstructionFlow.BL.Business;
using ConstructionFlow.Domain.Payload.Request;
using ConstructionFlow.Domain.Payload.Util;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionFlow.Api.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class UserController
    {
        private readonly UserBusiness _userBusiness;

        public UserController(UserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpGet]
        public async Task<IEnumerable<UserRequestDTO>> GetUsers()
        {
            return await _userBusiness.GetUsers();
        }

        [HttpGet("{userId}")]
        public UserRequestDTO GetUser(int userId)
        {
            return _userBusiness.GetUser(userId);
        }

        [HttpPost]
        public Task AddUser(UserLoginDTO user)
        {
            return _userBusiness.AddUser(user);
        }

        [HttpPut]
        public Task UpdateUser(UserRequestDTO user)
        {
            return _userBusiness.UpdateUser(user);
        }

        [HttpDelete("{userId}")]
        public Task DeleteUser(int userId)
        {
            return _userBusiness.DeleteUser(userId);
        }

        [HttpGet("/CNPJ/{userCNPJ}")]
        public UserRequestDTO GetUsersByCNPJ(string userCNPJ)
        {
            return _userBusiness.GetUsersByCNPJ(userCNPJ);
        }
    }
}
