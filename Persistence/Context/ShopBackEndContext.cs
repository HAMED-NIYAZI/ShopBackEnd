 using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ShopBackEndContext : DbContext
    {
        public ShopBackEndContext(DbContextOptions<ShopBackEndContext> options)
            : base(options)
        {

        }



        //dbsets

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
