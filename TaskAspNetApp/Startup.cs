using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TaskAspNetApp.Services;

namespace TaskAspNetApp
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			try
			{
				DBContext.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
			}
			catch (System.Exception e)
			{

				System.Console.WriteLine($"Error {e} \n Please check config file");
			}
			
			DBContext dBContext = new DBContext();
			if (!dBContext.Database.CanConnect())
			{
				System.Console.WriteLine("CANNOT GET CONNECT TO DATABASE!!!");
			}
			services.AddRazorPages();
			services.AddControllers();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
			});
		}
	}
}
