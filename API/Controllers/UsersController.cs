using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using API.Interfaces;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : APIController
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return Ok(await _userRepository.GetMembersAsync());
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUser(string username)
        {
            return Ok(await _userRepository.GetMemberByUsernameAsync(username));
        }
    }
}