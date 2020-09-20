using DataAcces.Query.Hold;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Hold.Concretes
{
    public class HoldCRUD : IHoldCRUD
    {
        private readonly IHoldQuery holdQuery;
        private readonly IHoldLinjeQuery holdLinjeQuery;

        public HoldCRUD(IHoldQuery holdQuery, IHoldLinjeQuery holdLinjeQuery)
        {
            this.holdQuery = holdQuery;
            this.holdLinjeQuery = holdLinjeQuery;
        }
        public async Task<List<Model.Hold>> GetAllHold()
        {
            return await holdQuery.GetAll();
        }
        public async Task<List<Model.Hold>> GetHoldWithoutSchema()
        {
           return await holdQuery.GetAllHoldWithoutSchema();
        }
        public async Task<List<Model.Hold>> GetAllHoldForPerson(Model.Person person)
        {
            var linjeListe = await holdLinjeQuery.GetHoldLinjeListFromPerson(person);
            var holdList = new List<Model.Hold>();
            foreach(var linje in linjeListe)
            {
                holdList.Add(linje.Hold);
            }
            return holdList;
        }
        public async Task<Model.Hold>GetHoldFromId(int id)
        {
            return await holdQuery.GetHoldWithIncludes(id);
        }
    }
}
