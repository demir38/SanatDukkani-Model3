using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sanat.MvcWebUI.Identity
{
    public class IndentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IndentityDataContext() : base("dataConnection")
        {
           
        }

    }
}