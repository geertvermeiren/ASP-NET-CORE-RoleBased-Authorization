using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShowFieldByUser.Models;

namespace ShowFieldByUser.Models
{
    public class ManageUsersViewModel
    {
     
        public IdentityUser[] Administrators { get; set; }
        public IdentityUser[] Everyone { get; set; }
    }
}
