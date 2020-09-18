using Infrastructure.Repository;
using Infrastructure.Repository.Hold.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Hold.Concretes
{
    public class HoldCRUD : IHoldCRUD
    {
        private readonly IHoldRepository holdRepository;
        private readonly IHoldLinjeRepository holdLinjeRepository;
        public HoldCRUD(IHoldRepository holdRepository, IHoldLinjeRepository holdLinjeRepository)
        {
            this.holdRepository = holdRepository;
            this.holdLinjeRepository = holdLinjeRepository;
        }
        public async Task<List<Model.Hold>> GetAllHold()
        {
            return await holdRepository.GetAll(null);
        }
        public async Task<List<Model.Hold>> GetAllHoldForPerson(Model.Person person)
        {
            var linjeListe = await holdLinjeRepository.GetHoldLinjeListFromPerson(person);
            var holdList = new List<Model.Hold>();
            foreach(var linje in linjeListe)
            {
                holdList.Add(linje.Hold);
            }
            return holdList;
        }
        public async Task<Model.Hold>GetHoldFromId(int id)
        {
            return await holdRepository.GetHoldWithIncludes(id);
        }
    }
}
