using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class HoldLinjer:BaseEntity
    {
        public Person Person { get; set; }
        public Hold Hold { get; set; }
        
    }
}
