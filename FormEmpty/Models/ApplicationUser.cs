using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FromEmpty.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string OpenId { get; set; }
        public string UnionId { get; set; }
    }
}