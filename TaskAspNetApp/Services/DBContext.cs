using Microsoft.EntityFrameworkCore;
using TaskAspNetApp.Models;

namespace TaskAspNetApp.Services
{
	public class DBContext : DbContext
	{
		public static string ConnectionString { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseMySql(ConnectionString);
		}
		public virtual DbSet<Contract> Contracts { get; set; }
		public virtual DbSet<StageContract> StageContracts { get; set; }

	}
}
