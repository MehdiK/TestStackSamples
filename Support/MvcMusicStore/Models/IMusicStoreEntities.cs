using System.Linq;

namespace MvcMusicStore.Models
{
    public interface IMusicStoreEntities
    {
        IQueryable<Album> Albums { get; }
        IQueryable<Genre> Genres { get; }
        IQueryable<Artist> Artists { get; }
        IQueryable<Cart> Carts { get; }
        IQueryable<Order> Orders { get; }
        IQueryable<OrderDetail> OrderDetails { get; }
        IQueryable<User> Users { get; }
    }
}
