using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRowVersion
    {
        byte[] RowVersion { get; set; }
    }
}
