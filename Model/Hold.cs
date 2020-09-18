using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Hold : BaseEntity
    {
        public string Name { get; set; }
        public List<HoldLinjer> HoldLinjer { get; set; }
        public int? CalenderId { get; set; }
        public Calender Calender { get; set; }

    }
}
