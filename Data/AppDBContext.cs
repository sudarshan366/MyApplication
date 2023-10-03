using System;
using MyFirstApplication.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApplication.Data
{
	public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options)
			: base(options)
		{
		}

		public DbSet<CourseModel> CourseModel { get; set; }

	}
    
}

