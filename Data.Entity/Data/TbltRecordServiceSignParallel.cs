using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltRecordServiceSignParallel
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? RecordServiceSigningId { get; set; }
        public Guid? DocumentId { get; set; }
        public string? Status { get; set; }
        public string? FileName { get; set; }
        public Guid? ProcessId { get; set; }

        public virtual TbltRecordServiceSigning? RecordServiceSigning { get; set; }
    }
}
