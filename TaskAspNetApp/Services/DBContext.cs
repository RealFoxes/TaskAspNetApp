using Microsoft.EntityFrameworkCore;
using TaskAspNetApp.Models;

namespace TaskAspNetApp.Services
{
	public class DBContext : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("Server=localhost;Database=ContractManagement;Uid=root;Pwd=;CharSet=utf8;");
		}
		public virtual DbSet<Contract> Contracts { get; set; }
		public virtual DbSet<StageContract> StageContracts { get; set; }

	}
}
