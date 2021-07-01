﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessControlManagementSoftware.Areas.Admin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccessControlManagementSoftware.Areas.Admin.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _iuserservice;
        public UserController(IUserService _iuserservice)
        {
            this._iuserservice = _iuserservice;
        }

        [HttpGet]
        public IActionResult Getusers()
        {
            var users = _iuserservice.getusers();
            return Ok(users);
        }
    }
}
