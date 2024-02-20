using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmSyncDirektorat
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CompanyCode { get; set; }
        public int? DirectorateLevel { get; set; }
    }
}
