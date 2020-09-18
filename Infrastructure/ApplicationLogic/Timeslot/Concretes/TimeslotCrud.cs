using Infrastructure.ApplicationLogic.Person.Concretes;
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
        private readonly IPersonState personState;
        public TimeslotCrud(ITimeslotRepository timeslotRepository, IPersonState personState)
        {
            this.timeslotRepository = timeslotRepository;
            this.personState = personState;
        }
        public async Task Create(Model.Timeslot slot)
        {
            slot.ValidateDates();
            slot.RemoveSeconds();
            var slotList = slot.DetermineSingleOrCollectionTimeslots();
            slotList = await TryAddToTeacher(slotList);
            foreach(var s in slotList)
            {
                await timeslotRepository.Create(s);

            }
        }
        public async Task<Model.Timeslot> GetFromId(int id)
        {
            return await timeslotRepository.GetWithIncludes(id);
        }
        private async Task<List<Model.Timeslot>> TryAddToTeacher(List<Model.Timeslot> slotList)
        {
            var teacher = (Model.Teacher)await personState.GetPersonAsync();
            var succesfullyAddedToTeacherList = new List<Model.Timeslot>();
            foreach (var ts in slotList)
            {
                if(teacher.AddTimeslot(ts))
                {
                    succesfullyAddedToTeacherList.Add(ts);
                }

            }
            return succesfullyAddedToTeacherList;
        }
    }
}
