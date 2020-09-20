using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Command.Hold
{
    public class HoldCommand : CommandRepository<Model.Hold>, IHoldCommand
    {
        public HoldCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
