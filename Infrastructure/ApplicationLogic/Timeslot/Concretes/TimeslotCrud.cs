using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public class TimeslotCrud : ITimeslotCrud
    {
        private readonly ITimeslotRepository timeslotRepository;
        public TimeslotCrud(ITimeslotRepository timeslotRepository)
        {
            this.timeslotRepository = timeslotRepository;
        }
        public async Task Create(Model.Timeslot slot)
        {
            slot.ValidateDates();
            slot.RemoveSeconds();
            await timeslotRepository.Create(slot);
        }
        public async Task<Model.Timeslot> GetFromId(int id)
        {
            return await timeslotRepository.GetWithIncludes(id);
        }
    }
}
