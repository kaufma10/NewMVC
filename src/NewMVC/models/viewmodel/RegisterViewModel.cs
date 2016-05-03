using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;

namespace NewMVC.models.viewmodel
{
    public class RegisterViewModel
    {
        [Authorize]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
