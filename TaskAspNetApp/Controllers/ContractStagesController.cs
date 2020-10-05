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
	// https://localhost:44302/api/controller/GetContractStages?idContract=1
	[Route("/api/Contracts/Get[controller]")]
	public class ContractStagesController : ControllerBase
	{
		[HttpGet]
		public IAsyncEnumerable<StageContract> Get(int idContract)
		{
			
			DBContext context = new DBContext();
			return context.StageContracts.Where(c => c.contract.Id == idContract).AsAsyncEnumerable();
		}
	}
}
