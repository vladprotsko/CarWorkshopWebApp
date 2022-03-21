using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Car_WorkshopWebApplication.Models
{
    public class Car_WorkshopContext : DbContext 
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public Car_WorkshopContext(DbContextOptions<Car_WorkshopContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}


