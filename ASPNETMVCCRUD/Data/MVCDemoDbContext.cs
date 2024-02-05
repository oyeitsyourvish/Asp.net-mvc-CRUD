﻿using ASPNETMVCCRUD.Models.Domains;
using Microsoft.EntityFrameworkCore;


namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
