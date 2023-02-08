// https://gist.github.com/davidfowl/0e0372c3c1d895c3ce195ba983b1e03d

using WebApp;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

// Uncomment if using a custom DI container
// builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
// builder.Host.ConfigureContainer<ContainerBuilder>(startup.ConfigureContainer);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();