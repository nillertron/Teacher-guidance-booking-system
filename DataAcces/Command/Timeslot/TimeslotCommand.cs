using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DataAcces.Command.Timeslot
{
    public class TimeslotCommand : CommandRepository<Model.Timeslot>, ITimeslotCommand
    {
        public TimeslotCommand(VejledningsContext context) : base(context)
        {

        }
        public async Task UpdateWithConcurrencyCheck(Model.Timeslot entity)
        {
            var result = context.Database.ExecuteSqlRaw("Update Timeslots set BookingId = {0} where Id = {1} AND RowVersion = {2}", entity.BookingId, entity.Id, entity.RowVersion);
            if (result < 1)
                throw new Exception("Concurrency exception");
        }
    }
}
