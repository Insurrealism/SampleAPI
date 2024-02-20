using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltInactiveArchiveManagementHistory
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? InactiveArchiveManagementStatusFileId { get; set; }
        public Guid? InactiveArchiveManagementHeaderSenderId { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
        public string? UserPelaku { get; set; }
        public string? MenuText { get; set; }
        public string? SubmenuText { get; set; }
        public string? CommentText { get; set; }

        public virtual TbltInactiveArchiveManagementHeaderSender? InactiveArchiveManagementHeaderSender { get; set; }
        public virtual TblmInactiveArchiveManagementStatusFile? InactiveArchiveManagementStatusFile { get; set; }
    }
}
