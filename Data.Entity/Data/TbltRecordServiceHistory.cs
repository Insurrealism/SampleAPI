using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltRecordServiceHistory
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? RecordServiceStatusFileId { get; set; }
        public Guid? RecordServiceHeaderSenderId { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
        public string? UserPelaku { get; set; }
        public string? MenuText { get; set; }
        public string? SubmenuText { get; set; }
        public string? CommentText { get; set; }

        public virtual TbltRecordServiceHeaderSender? RecordServiceHeaderSender { get; set; }
        public virtual TblmRecordServicesStatusFile? RecordServiceStatusFile { get; set; }
    }
}
