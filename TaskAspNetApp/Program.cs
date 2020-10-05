using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


using TaskAspNetApp.Services;

namespace TaskAspNetApp
{
	public class Program
	{
        public static void Main(string[] args)
        {
            //ExcelHandler excelHandler = new ExcelHandler(File.OpenRead("D:/Documents/ContractsExample.xlsx"));
            //var x = excelHandler.GetContractsFromExcel();
            //using (DBContext dBContext = new DBContext())
            //{
            //    dBContext.Contracts.AddRange(x);
            //    dBContext.SaveChanges();
            //}

            CreateHostBuilder(args).Build().Run();
        }

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});

       

        //public static IWorkbook ReadWorkbook(string path)
        //{
        //    IWorkbook book;

        //        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

        //        // Try to read workbook as XLSX:
        //        try
        //        {
        //            book = new XSSFWorkbook(fs);
        //        }
        //        catch
        //        {
        //            book = null;
        //        }

        //        // If reading fails, try to read workbook as XLS:
        //        if (book == null)
        //        {
        //            book = new HSSFWorkbook(fs);
        //        }
        //    return book;
        //}
    }
}
