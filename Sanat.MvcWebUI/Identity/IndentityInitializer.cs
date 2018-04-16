using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sanat.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sanat.MvcWebUI.Identity
{
    public class IndentityInitializer : CreateDatabaseIfNotExists<IndentityDataContext>
    {
        protected override void Seed(IndentityDataContext context)
        {
            //rolleri
            if(!context.Roles.Any(i=> i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new  RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name="admin",Description="admin rolü"};
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }
            //userlar
            if (!context.Users.Any(i => i.Name == "mustafademir"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name="mustafa",Surname="demir",UserName="mustafademir",Email="dmrrrr.mstf@gmail.com"};
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "yusufdemir"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "yusuf", Surname = "demir", UserName = "yusufdemir", Email = "dmrrrr.ysf@gmail.com" };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }


         



            base.Seed(context);
        }
    }
}