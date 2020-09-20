using System.Threading.Tasks;

namespace DataAcces.Query.Booking
{
    public interface IBookingQuery:IQueryRepository<Model.Booking>
    {
        Task<Model.Booking> GetWithInclude(int id);
    }
}