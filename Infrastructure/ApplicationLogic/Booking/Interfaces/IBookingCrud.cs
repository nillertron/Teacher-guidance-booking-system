using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Booking.Concretes
{
    public interface IBookingCrud
    {
        Task CreateBooking(Model.Booking booking);
    }
}