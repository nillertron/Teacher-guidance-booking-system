using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Command.Hold
{
    public class HoldLinjeCommand : CommandRepository<Model.HoldLinjer>, IHoldLinjeCommand
    {
        public HoldLinjeCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
