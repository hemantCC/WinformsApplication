using Assignment.Entity.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Changes the password.
        /// </summary>
        /// <param name="changePassData">The change pass data.</param>
        /// <returns></returns>
        Task<bool> ChangePassword(ChangePasswordViewModel changePassData);

        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="userViewModel">The user view model.</param>
        /// <returns></returns>
        Task<bool> PostUserAsync(UserViewModel userViewModel);

        /// <summary>
        /// Logins asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<string> LoginAsync(string username, string password);

        /// <summary>
        /// Checks if Usernames exists asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        Task<bool> UsernameExistsAsync(string username);

        /// <summary>
        /// Gets the roles asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetRolesAsync();
    }
}
