using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenPeaceAPI.Models
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRoleStatus { get; set; }


    }

    public class RegisterRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}