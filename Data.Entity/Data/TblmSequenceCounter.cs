using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmSequenceCounter
    {
        public string Name { get; set; } = null!;
        public int Sequence { get; set; }
        public int? Year { get; set; }
    }
}
