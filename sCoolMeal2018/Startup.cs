﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using sCoolMeal2018.Models;

[assembly: OwinStartupAttribute(typeof(sCoolMeal2018.Startup))]
namespace sCoolMeal2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           // createRoles();
        }


        // In this method we will create default User roles and Admin user for login   
        //private void createRoles()
        //{
        //    sCoolMealWebDBEntities context = new sCoolMealWebDBEntities();

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


        //    // In Startup iam creating first Admin Role and creating a default Admin User    
        //    if (!roleManager.RoleExists("Admin"))
        //    {

        //        // first we create Admin rool   
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Admin";
        //        roleManager.Create(role);
               
        //    }

        //    //if (!roleManager.RoleExists("Packing"))
        //    //{
        //    //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //    //    role.Name = "Packing";
        //    //    roleManager.Create(role);
        //    //}

        //    //if (!roleManager.RoleExists("Delivery"))
        //    //{
        //    //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //    //    role.Name = "Delivery";
        //    //    roleManager.Create(role);
        //    //}


        //    //if (!roleManager.RoleExists("SchoolAdmin"))
        //    //{
        //    //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //    //    role.Name = "SchoolAdmin";
        //    //    roleManager.Create(role);
        //    //}

        //    //if (!roleManager.RoleExists("User"))
        //    //{
        //    //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //    //    role.Name = "User";
        //    //    roleManager.Create(role);
        //    //}
        //}
    }
}
