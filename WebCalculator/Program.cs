var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseFileServer();
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
