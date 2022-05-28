using Common.Utilities;
using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{ 
	public class ApplicationDbContext:IdentityDbContext 
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{

		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	base.OnConfiguring(optionsBuilder);
		//	optionsBuilder.UseSqlServer();
		//}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			var enitiesAssembly = typeof(IEntity).Assembly;

			modelBuilder.RegisterAllEntities<IEntity>(enitiesAssembly);
			modelBuilder.RegisterEntityTypeConfiguration(enitiesAssembly);
			modelBuilder.AddRestrictDeleteBehaviorConvention();
			modelBuilder.AddSequentialGuidForIdConvention();
			modelBuilder.AddPluralizingTableNameConvention();
		}
	}
}
