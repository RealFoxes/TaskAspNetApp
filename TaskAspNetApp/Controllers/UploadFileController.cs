using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TaskAspNetApp.Models;
using TaskAspNetApp.Services;

namespace TaskAspNetApp.Controllers
{
	[ApiController]
	[Route("/api/Import/[controller]")]
	public class UploadFileController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> Import(IFormFile file)
		{
			if (file == null) return Content("Error: File is null");
			string fileExtension = Path.GetExtension(file.FileName);
			if (fileExtension != ".xls" && fileExtension != ".xlsx") return Content("Error: Wrong file extension");
			var stream = file.OpenReadStream();
			List<Contract> contracts = await Task.Run(()=>{
				ExcelHandler excelHandler = new ExcelHandler(stream,fileExtension);
				return excelHandler.GetContractsFromExcel();
			});
			DBContext dBContext = new DBContext();
			await dBContext.Contracts.AddRangeAsync(contracts);
			await dBContext.SaveChangesAsync();
			return Content("All good");
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Content("Need Use post request with parameter \"file\"");
		}
	}
}
