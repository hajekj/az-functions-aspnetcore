using Microsoft.Extensions.Hosting;
using NL.Serverless.AspNetCore.AzureFunctionsHost;

var host = new HostBuilder()
	.ConfigureFunctionsWorkerDefaults()
	.ConfigureWebAppFunctionHost<WebApp.Startup>()
	.Build();

host.Run();
