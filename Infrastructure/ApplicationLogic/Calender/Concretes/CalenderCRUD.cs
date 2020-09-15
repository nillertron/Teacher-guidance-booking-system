using Infrastructure.ApplicationLogic.Hold.Concretes;
using Infrastructure.Repository;
using Infrastructure.Repository.Calender.Concretes;
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
        public CalenderCRUD(ICalenderRepository calenderRepository)
        {
            this.calenderRepository = calenderRepository;
        }
        public async Task Create(Model.Calender model)
        {
            await calenderRepository.Create(model);

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
