using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltRecordServiceAttachment
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? RecordServiceHeaderSenderId { get; set; }
        public int? Sequence { get; set; }
        public string? FileNameSystem { get; set; }
        public string? FileNameUser { get; set; }

        public virtual TbltRecordServiceHeaderSender? RecordServiceHeaderSender { get; set; }
    }
}
