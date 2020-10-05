using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

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
