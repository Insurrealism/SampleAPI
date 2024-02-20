using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmFileTransferSigningStatusFile
    {
        public TblmFileTransferSigningStatusFile()
        {
            TbltFileTransferSigningHistories = new HashSet<TbltFileTransferSigningHistory>();
            TbltFileTransferSignings = new HashSet<TbltFileTransferSigning>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
        public string? StepDescription { get; set; }
        public string? UserPelaku { get; set; }
        public string? UserTahapLanjut { get; set; }
        public string? NextStepCode { get; set; }
        public string? ReviseStepCode { get; set; }
        public string? RejectStepCode { get; set; }
        public string? EmailReceiver { get; set; }
        public string? MenuText { get; set; }
        public string? SubmenuText { get; set; }
        public string? WarnaStatus { get; set; }
        public string? ActionName { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Icon { get; set; }
        public string? Tooltip { get; set; }
        public string? RoleAccess { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }

        public virtual ICollection<TbltFileTransferSigningHistory> TbltFileTransferSigningHistories { get; set; }
        public virtual ICollection<TbltFileTransferSigning> TbltFileTransferSignings { get; set; }
    }
}
