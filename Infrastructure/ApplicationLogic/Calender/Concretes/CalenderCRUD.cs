using Infrastructure.ApplicationLogic.Hold.Concretes;
using Infrastructure.Repository;
using Infrastructure.Repository.Calender.Concretes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public class CalenderCRUD : ICalenderCRUD
    {
        private readonly ICalenderRepository calenderRepository;
        private readonly IServiceScopeFactory serviceScopeFactory;
        public CalenderCRUD(ICalenderRepository calenderRepository, IServiceScopeFactory serviceScopeFactory)
        {
            this.calenderRepository = calenderRepository;
            this.serviceScopeFactory = serviceScopeFactory;
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
            //temporary because i had problems with dbcontext being used by multiple threads
            var scope = serviceScopeFactory.CreateScope();
            using (scope)
            {
               var db = scope.ServiceProvider.GetService<ICalenderRepository>();
               return await db.GetCalenderWithIncludes(hold);

            }
        }
    }
}
