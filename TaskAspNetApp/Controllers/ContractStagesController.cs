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
		[HttpGet("{idContract:int}")]
		public IAsyncEnumerable<StageContract> Get(int idContract)
		{
			//if (idContract == 0) return "Need parameter \"Id\" of contract. Example";
			DBContext context = new DBContext();
			return context.StageContracts.Where(c => c.contract.Id == idContract).AsAsyncEnumerable();
		}
		[HttpGet]
		public IActionResult Get()
		{
			return Content("Need parameter \"Id\" of contract. Example: \"https://localhost:44302/api/Contracts/GetContractStages/9\"");
			
		}

	}
}
