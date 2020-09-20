using DataAcces.Command.Timeslot;
using DataAcces.Query.Person;
using DataAcces.Query.Timeslot;
using Infrastructure.ApplicationLogic.Person.Concretes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public class TimeslotCrud : ITimeslotCrud
    {
        private readonly IPersonState personState;
        private readonly ITimeslotQuery timeslotQuery;
        private readonly ITimeslotCommand timeslotCommand;
        private readonly ITeacherQuery teacherQuery;
        public TimeslotCrud(IPersonState personState, ITimeslotCommand timeslotCommand, ITimeslotQuery timeslotQuery, ITeacherQuery teacherQuery)
        {
            this.personState = personState;
            this.timeslotQuery = timeslotQuery;
            this.timeslotCommand = timeslotCommand;
            this.teacherQuery = teacherQuery;
        }
        public async Task Create(Model.Timeslot slot)
        {
            slot.ValidateDates();
            slot.RemoveSeconds();
            var slotList = slot.DetermineSingleOrCollectionTimeslots();
            slotList = await TryAddToTeacher(slotList);
            foreach(var s in slotList)
            {
                await timeslotCommand.Create(s);

            }
        }
        public async Task<Model.Timeslot> GetFromId(int id)
        {
            return await timeslotQuery.GetWithIncludes(id);
        }
        private async Task<List<Model.Timeslot>> TryAddToTeacher(List<Model.Timeslot> slotList)
        {
            var teacherId = await personState.GetPersonIdAsync();
            var teacher = await teacherQuery.GetTeacherWithFutureTimeslots(teacherId);
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
