using Infrastructure.ApplicationLogic.Hold.Concretes;
using Infrastructure.Repository;
using Infrastructure.Repository.Calender.Concretes;
using Infrastructure.Repository.Hold.Concretes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public class CalenderCRUD : ICalenderCRUD
    {
        private readonly ICalenderRepository calenderRepository;
        private readonly IHoldRepository holdRepository;
        private readonly ITimeslotRepository timeslotRepository;
        public CalenderCRUD(ICalenderRepository calenderRepository, IHoldRepository holdRepository, ITimeslotRepository timeslotRepository)
        {
            this.calenderRepository = calenderRepository;
            this.holdRepository = holdRepository;
            this.timeslotRepository = timeslotRepository;
        }
        public async Task Create(Model.Calender model)
        {
            var holdListe = model.Hold;
            model.Hold = null;
            await calenderRepository.Create(model);
            foreach (var hold in holdListe)
            {
                hold.CalenderId = model.Id;
                await holdRepository.Update(hold);
            }

        }
        public async Task<List<Model.Calender>> GetAll()
        {
            return await calenderRepository.GetAll((x => x.Hold), (z => z.Timeslots));
        }
        public async Task<Model.Calender> Get(Model.Hold hold)
        {
            return await calenderRepository.GetCalenderWithIncludes(hold);
        }
        public async Task<Model.Calender> Get(int calenderId)
        {
            return await calenderRepository.GetCalenderWithIncludes(calenderId);
        }
    }
}
