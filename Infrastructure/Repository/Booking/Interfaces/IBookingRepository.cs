using System.Threading.Tasks;

namespace Infrastructure.Repository.Booking.Concretes
{
    public interface IBookingRepository:IRepository<Model.Booking>
    {
        Task<Model.Booking> GetWithInclude(int id);
    }
}