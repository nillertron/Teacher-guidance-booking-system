using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class StoredCookie:BaseEntity
    {
        public string Value { get; set; }
        public Person Person { get; set; }
    }
}
