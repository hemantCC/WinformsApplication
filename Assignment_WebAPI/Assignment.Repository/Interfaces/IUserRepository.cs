using Assignment.Entity.Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="tblUser">The table user.</param>
        /// <returns></returns>
        Task<bool> PostUserAsync(TblUser tblUser);

        /// <summary>
        /// Gets the role by name asynchronous.
        /// </summary>
        /// <param name="roleName">Name of the role.</param>
        /// <returns></returns>
        Task<TblRole> GetRoleByNameAsync(string roleName);

        /// <summary>
        /// Logins asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<string> LoginAsync(string username, string password);

        /// <summary>
        /// Usernames the exists asynchronous.
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
