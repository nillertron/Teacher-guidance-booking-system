using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Command.Calender
{
    public class CalenderCommand : CommandRepository<Model.Calender>, ICalenderCommand
    {
        public CalenderCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
