using BookingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> x): base(x){}
        public DbSet<Value> Values{get;set;}

        public DbSet<User> Users{get;set;}
    }
}