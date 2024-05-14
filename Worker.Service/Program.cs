var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker.Service.Worker>();

var host = builder.Build();
host.Run();