using UI;
using System;
using System.Collections.Generic; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
// using DL.Entities;
using BL;
using DL;

/* var Configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json")
.Build(); */

// string connectionString = Configuration.GetConnectionString("petdb");    
//DbContextOptions<petdbContext> options = new DbContextOptionsBuilder<petdbContext>();
  //  .UseSqlServer(connectionString)
    // .Options;

// var context = new petdbContext(options);


    


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program.cs");
           // IMenu menu = new MainMenu(new PetBL(new PetRepo(context)));
            // menu.Start();
           
        }

        

         

        
        
    }
}
