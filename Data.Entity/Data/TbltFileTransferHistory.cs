using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltFileTransferHistory
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? FileTransferStatusFileId { get; set; }
        public Guid? FileTransferHeaderSenderId { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
        public string? UserPelaku { get; set; }
        public string? MenuText { get; set; }
        public string? SubmenuText { get; set; }
        public string? CommentsText { get; set; }

        public virtual TbltFileTransferHeaderSender? FileTransferHeaderSender { get; set; }
        public virtual TblmFileTransferStatusFile? FileTransferStatusFile { get; set; }
    }
}
