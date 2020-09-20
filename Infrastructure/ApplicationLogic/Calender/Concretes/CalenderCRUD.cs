using DataAcces.Command.Calender;
using DataAcces.Command.Hold;
using DataAcces.Query.Calender;
using Infrastructure.ApplicationLogic.Hold.Concretes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public class CalenderCRUD : ICalenderCRUD
    {
        private readonly ICalenderCommand calenderCommand;
        private readonly ICalenderQuery calenderQuery;
        private readonly IHoldCommand holdCommand;

        public CalenderCRUD(ICalenderCommand calenderCommand,ICalenderQuery calenderQuery, IHoldCommand holdCommand)
        {
            this.calenderQuery = calenderQuery;
            this.calenderCommand = calenderCommand;
            this.holdCommand = holdCommand;
        }
        public async Task Create(Model.Calender model)
        {
            var holdListe = model.Hold;
            model.Hold = null;
            await calenderCommand.Create(model);
            foreach (var hold in holdListe)
            {
                hold.CalenderId = model.Id;
                await holdCommand.Update(hold);
            }

        }
        public async Task<List<Model.Calender>> GetAll()
        {
            return await calenderQuery.GetAll((x => x.Hold), (z => z.Timeslots));
        }
        public async Task<Model.Calender> Get(Model.Hold hold)
        {
            return await calenderQuery.GetCalenderWithIncludes(hold);
        }
        public async Task<Model.Calender> Get(int calenderId)
        {
            return await calenderQuery.GetCalenderWithIncludes(calenderId);
        }
    }
}
