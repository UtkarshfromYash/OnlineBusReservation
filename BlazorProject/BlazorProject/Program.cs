using System.Reflection;
using BlazorProject.Client.Pages;
using BlazorProject.Components;
using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");
 
  builder.Services.AddDbContext<AppDbContext>(options =>

      options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBusRepository,BusRepository>();
builder.Services.AddScoped<IBusService,BusService>();    
builder.Services.AddScoped<IBusScheduleRepository,BusScheduleRepository>();
builder.Services.AddScoped<IBusScheduleService,BusScheduleService>();  
builder.Services.AddScoped<IBookingRepository,BookingRepository>();
builder.Services.AddScoped<IBookingService,BookingService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();
app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorProject.Client._Imports).Assembly);

app.Run();
