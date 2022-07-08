using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using PresentationLayer;

var builder = WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>();

var app = builder.Build();

app.Run();