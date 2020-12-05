using Assignment.Entity.Entities.DataEntities;
using Assignment.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        #region Private Member

        /// <summary>
        /// The Database context
        /// </summary>
        private readonly DbAssignmentContext _context;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="Context">The context.</param>
        public UserRepository(DbAssignmentContext Context)
        {
            _context = Context;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the role by name asynchronous.
        /// </summary>
        /// <param name="roleName">Name of the role.</param>
        /// <returns></returns>
        public async Task<TblRole> GetRoleByNameAsync(string roleName)
        {
            return await _context.TblRoles.Where(x => x.RoleName == roleName).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets the roles asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetRolesAsync()
        {
            return await _context.TblRoles.Select(x => x.RoleName).Skip(2).ToListAsync();
        }

        /// <summary>
        /// Logins asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<string> LoginAsync(string username, string password)
        {
            string role = null;
            TblUser user = await _context.TblUsers.Where(x => x.Username == username && x.Password == password).Include("Role")
                .FirstOrDefaultAsync();
            if (user != null)
            {
                role = user.Role.RoleName;
            }
            return role;
        }

        /// <summary>
        /// Posts the user asynchronous.
        /// </summary>
        /// <param name="tblUser">The table user.</param>
        /// <returns></returns>
        public async Task<bool> PostUserAsync(TblUser tblUser)
        {
            await _context.TblUsers.AddAsync(tblUser);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Usernames the exists asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _context.TblUsers.AnyAsync(x => x.Username == username);
        }

        #endregion
    }
}
