using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskAspNetApp.Models;
using TaskAspNetApp.Services;

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
