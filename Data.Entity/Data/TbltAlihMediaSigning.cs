using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaSigning
    {
        public TbltAlihMediaSigning()
        {
            TbltAlihMediaBaSignings = new HashSet<TbltAlihMediaBaSigning>();
            TbltAlihMediaFileSignings = new HashSet<TbltAlihMediaFileSigning>();
            TbltAlihMediaSignParallels = new HashSet<TbltAlihMediaSignParallel>();
            TbltAlihMediaSigningHistories = new HashSet<TbltAlihMediaSigningHistory>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CompanyCode { get; set; }
        public string? SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? AssignedBy { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string? AssignedTo { get; set; }
        public string? SurveyBy { get; set; }
        public DateTime? SurveyDate { get; set; }
        public string? RequestNumber { get; set; }
        public Guid? StatusId { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }
        public int? JumlahBerkas { get; set; }
        public string? FileNameSystem { get; set; }
        public bool? StatusSigning { get; set; }
        public Guid? AlihMediaHeaderSenderId { get; set; }

        public virtual TbltAlihMediaHeaderSender? AlihMediaHeaderSender { get; set; }
        public virtual TblmAlihMediaSigningStatusFile? Status { get; set; }
        public virtual ICollection<TbltAlihMediaBaSigning> TbltAlihMediaBaSignings { get; set; }
        public virtual ICollection<TbltAlihMediaFileSigning> TbltAlihMediaFileSignings { get; set; }
        public virtual ICollection<TbltAlihMediaSignParallel> TbltAlihMediaSignParallels { get; set; }
        public virtual ICollection<TbltAlihMediaSigningHistory> TbltAlihMediaSigningHistories { get; set; }
    }
}
