using AccessControlManagementSoftware.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessControlManagementSoftware.Models;

namespace AccessControlManagementSoftware.Areas.Admin.Services
{
    public class UserService : IUserService
    { 
        private readonly ApplicationDbContext _db;
        public UserService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public IEnumerable<ApplicationUser> getusers()
        {
            return _db.Users;
        }

    }
}
