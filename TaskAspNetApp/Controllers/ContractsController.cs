using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskAspNetApp.Models;
using TaskAspNetApp.Services;
using Microsoft.EntityFrameworkCore;

namespace TaskAspNetApp.Controllers
{
	[ApiController]
	[Route("/api/Contracts/Get[controller]")]
	public class ContractsController : ControllerBase
	{
		[HttpGet]
		public IAsyncEnumerable<Contract> Get()
		{
			DBContext context = new DBContext();
				return context.Contracts.Include(s => s.Stages).AsAsyncEnumerable();
		}

	}
}
