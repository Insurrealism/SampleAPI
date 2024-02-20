using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmRole
    {
        public TblmRole()
        {
            TblmRoleFeatures = new HashSet<TblmRoleFeature>();
            TbltAlihMediaFileSignings = new HashSet<TbltAlihMediaFileSigning>();
            TbltFileSignings = new HashSet<TbltFileSigning>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Name { get; set; }
        public bool? IsAdd { get; set; }
        public bool? IsRevise { get; set; }
        public bool? IsReject { get; set; }
        public bool? IsApprove { get; set; }
        public bool? IsDownload { get; set; }
        public bool? IsSubmit { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsSurvey { get; set; }
        public bool? IsUpload { get; set; }
        public bool? IsAssign { get; set; }
        public bool? IsReassign { get; set; }
        public bool? IsSignDocument { get; set; }
        public bool? IsReturned { get; set; }
        public bool? IsExtend { get; set; }
        public bool? IsBorrowed { get; set; }
        public bool? IsReview { get; set; }
        public bool? IsExpired { get; set; }
        public bool? IsAddFileTransfer { get; set; }
        public bool? IsUpdateInventory { get; set; }
        public bool? IsSubmitAll { get; set; }
        public bool? IsSelect { get; set; }
        public bool? IsAddAlihMedia { get; set; }
        public bool? IsReviseAlihMedia { get; set; }
        public bool? IsApproveAlihMedia { get; set; }
        public bool? IsRejectAlihMedia { get; set; }

        public virtual ICollection<TblmRoleFeature> TblmRoleFeatures { get; set; }
        public virtual ICollection<TbltAlihMediaFileSigning> TbltAlihMediaFileSignings { get; set; }
        public virtual ICollection<TbltFileSigning> TbltFileSignings { get; set; }
    }
}
