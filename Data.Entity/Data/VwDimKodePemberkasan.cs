using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class VwDimKodePemberkasan
    {
        public Guid KppId { get; set; }
        public string? KppCode { get; set; }
        public string? KppDescription { get; set; }
        public Guid KspId { get; set; }
        public string? KspCode { get; set; }
        public string? KspDescription { get; set; }
    }
}
