using System;
using System.Collections.Generic;
using System.Text;

namespace Pertamina.PRIME.Models.BaseModel
{
    public class PageInfo
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
    }
}
