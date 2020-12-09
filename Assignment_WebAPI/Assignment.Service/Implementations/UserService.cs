using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Entity.Entities.DataEntities;
using Assignment.Repository.Interfaces;
using Assignment.Service.Interfaces;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Implementations
{
    public class UserService : IUserService
    {
        #region Private members        

        /// <summary>
        /// The user repository
        /// </summary>
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="UserRepository">The user repository.</param>
        /// <param name="mapper">The mapper.</param>
        public UserService(IUserRepository UserRepository, IMapper mapper)
        {
            _userRepository = UserRepository;
            this._mapper = mapper;
        }

        #endregion

        #region public Methods

        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePassData">The change pass data.</param>
        /// <returns></returns>
        public async Task<bool> ChangePassword(ChangePasswordViewModel changePassData)
        {
            return await _userRepository.ChangePassword(changePassData);
        }

        /// <summary>
        /// Gets the roles asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetRolesAsync()
        {
            return await _userRepository.GetRolesAsync();
        }

        /// <summary>
        /// Logins asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<string> LoginAsync(string username, string password)
        {
            return await _userRepository.LoginAsync(username,password);
        }

        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="userViewModel">The user view model.</param>
        /// <returns></returns>
        public async Task<bool> PostUserAsync(UserViewModel userViewModel)
        {
            TblUser user = _mapper.Map<TblUser>(userViewModel);
            user.Role = await _userRepository.GetRoleByNameAsync(userViewModel.Role);
            return await _userRepository.PostUserAsync(user);
        }

        /// <summary>
        /// Checks if Usernames exists asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _userRepository.UsernameExistsAsync(username);
        }

        #endregion

        #region Private Methods

        private async Task<string> GenerateToken()
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Role","Admin")
                    }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        "My Secret Key")), SecurityAlgorithms.HmacSha256),
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return await Task.FromResult(token);
        } 

        #endregion
    }
}
