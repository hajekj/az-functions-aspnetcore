using Microsoft.AspNetCore.Hosting.StaticWebAssets;

namespace WebApp
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (!env.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			if (Configuration["FUNCTION_staticWebAssets"] == "true")
			{
				StaticWebAssetsLoader.UseStaticWebAssets(env, Configuration);
			}
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
