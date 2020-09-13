using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Hold : BaseEntity
    {
        public string Name { get; set; }
        public List<HoldLinjer> HoldLinjer { get; set; }

    }
}
