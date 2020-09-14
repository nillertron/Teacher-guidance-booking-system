using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
    class HoldRepository : Repository<Model.Hold>, IHoldRepository
    {
        public HoldRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task DummyMethod()
        {

        }
    }
}
