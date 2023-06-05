﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;


public class Program
{
    private readonly Microsoft.AspNet.Identity.RoleManager<IdentityRole> _roleManager;
    private readonly Microsoft.AspNet.Identity.UserManager<IdentityUser> _userManager;

    public Program(Microsoft.AspNet.Identity.RoleManager<IdentityRole> roleManager, Microsoft.AspNet.Identity.UserManager<IdentityUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async void CreateRole(string roleName)
    {
        try
        {
            if (!string.IsNullOrEmpty(roleName))
            {
                if (!(await _roleManager.RoleExistsAsync(roleName)))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));

                }
            }

        }
        catch (Exception ex)
        {

        }

    }
    static void Main(string[] args)
    {
        //ApplicationDbContext context = new ApplicationDbContext();

        //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(builder));
        //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        string roleName = "Administrador";

        Program program = new Program();

        program.CreateRole(roleName);
       
    }
}