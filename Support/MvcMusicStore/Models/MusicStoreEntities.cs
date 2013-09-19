using System.Data.Entity;
using System.Linq;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : DbContext, IMusicStoreEntities
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        IQueryable<Album> IMusicStoreEntities.Albums
        {
            get { return Albums; }
        }

        IQueryable<Genre> IMusicStoreEntities.Genres
        {
            get { return Genres; }
        }

        IQueryable<Artist> IMusicStoreEntities.Artists
        {
            get { return Artists; }
        }

        IQueryable<Cart> IMusicStoreEntities.Carts
        {
            get { return Carts; }
        }

        IQueryable<Order> IMusicStoreEntities.Orders
        {
            get { return Orders; }
        }

        IQueryable<OrderDetail> IMusicStoreEntities.OrderDetails
        {
            get { return OrderDetails; }
        }

        IQueryable<User> IMusicStoreEntities.Users
        {
            get { return Users; }
        }
    }
}