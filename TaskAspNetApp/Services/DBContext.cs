using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAspNetApp.Models;

namespace TaskAspNetApp.Services
{
	public class DBContext : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("Server=localhost;Database=ContractManagement;Uid=root;Pwd=;CharSet=utf8;");
			//optionsBuilder.UseMySql("Server=188.120.248.48;Database=ContractManagement;Uid=Real_Foxes;Pwd=buNvFd4KEcwfsX0y;CharSet=utf8;");
		}
		public virtual DbSet<Contract> Contracts { get; set; }
		public virtual DbSet<StageContract> StageContracts { get; set; }

	}
}
