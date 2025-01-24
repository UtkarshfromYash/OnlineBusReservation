using BlazorProject.Models;
using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        

        public DbSet<User>Users{get; set;}
        public DbSet<AddUpdateModel> AddUpdateModels { get; set; }
    }