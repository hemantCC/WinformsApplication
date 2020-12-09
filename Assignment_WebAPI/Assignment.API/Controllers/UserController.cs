using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Private Member

        /// <summary>
        /// The user service
        /// </summary>
        private readonly IUserService _userService;

        #endregion

        #region Constructor

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Public Controller Methods

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="userChangePassData">The user change pass data.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel userChangePassData)
        {
            bool result = await _userService.ChangePassword(userChangePassData);
            if (result == true)
            {
                return Ok("User Added Successfully.");
            }
            return BadRequest("Something went wrong!");
        }

        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="userViewmodel">The user viewmodel.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("PostUser")]
        public async Task<IActionResult> PostUserAsync(UserViewModel userViewmodel)
        {
            bool result = await _userService.PostUserAsync(userViewmodel);
            if (result == true)
            {
                return Ok("User Added Successfully.");
            }
            return BadRequest("Something went wrong!");
        }

        /// <summary>
        /// Logins  asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync(string username,string password)
        {
            string role = await _userService.LoginAsync(username, password);
            if (role == null)
            {
                return BadRequest("Login Failed!");
            }
            return Ok(role);
        }

        /// <summary>
        /// Checks if username exists.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("CheckIfUsernameExists")]
        public async Task<IActionResult> CheckIfUsernameExists(string username)
        {
            bool result = await _userService.UsernameExistsAsync(username);
            if (result == false)
            {
                return BadRequest("Email Already exists!");
            }
            return Ok(result);
        }

        /// <summary>
        /// Gets all roles.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            IEnumerable<string> roles = await _userService.GetRolesAsync();
            if (roles == null)
            {
                return BadRequest("No Roles Found!");
            }
            return Ok(roles);
        }

        #endregion
    }
}
