﻿using Company.Data.Entites;
using Company.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Contexts
{
	public class CompanyDbContext : IdentityDbContext<ApplicationUser>
	{
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
            
        }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("server=.; database = CompanyMVCG01; trusted_connections=true;TrustServerCertificate=true");
		//}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			//modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.isDeleted);

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Employee> Employees { get; set; }

		public DbSet<Department> Departments { get; set; }
	}
}
