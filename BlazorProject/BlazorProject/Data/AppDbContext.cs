using BlazorProject.Models;
using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;
using Route = BlazorProject.Models.Models.Route;

public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }     
        public DbSet<User>Users{get; set;}
        public DbSet<AddUpdateModel> AddUpdateModels { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<BusSchedule> BusSchedules { get; set; }
        public DbSet<BusScheduleSearchModel> BusScheduleSearchModels { get; set; }
        public DbSet<BusScheduleViewModel> BusScheduleViewModels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }