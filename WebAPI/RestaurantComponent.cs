using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;



namespace RestaurantAngular.Models
{
    [Table("tblAngularRestaurant")]
    public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int price { get; set; }
        public string Image { get; set; } = string.Empty;
    }
    public class AngularDB : DbContext
    {
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            const string STRCONN = @"Data Source=W-674PY03-1;Initial Catalog=HariDB;Persist Security Info=True;User ID=sa;Password=Password@12345; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(STRCONN);
        }
    }
}