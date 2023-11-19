using IdentityServer;
using IdentityServer4.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddInMemoryClients(Config.Clients)
    .AddInMemoryApiScopes(Config.ApiScopes) 
    .AddDeveloperSigningCredential()
    ;

var app = builder.Build();

app.UseRouting();
app.UseIdentityServer();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World"); });
});


app.Run();
