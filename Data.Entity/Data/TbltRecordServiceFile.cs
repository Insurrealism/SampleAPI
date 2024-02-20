using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltRecordServiceFile
    {
        public Guid Id { get; set; }
        public Guid? RecordServiceHeaderSenderId { get; set; }
        public Guid? InactiveArchiveManagementHeaderSenderId { get; set; }
        public int? Sequence { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TbltInactiveArchiveManagementHeaderSender? InactiveArchiveManagementHeaderSender { get; set; }
        public virtual TbltRecordServiceHeaderSender? RecordServiceHeaderSender { get; set; }
    }
}
