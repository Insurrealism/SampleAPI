using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltFileTransferSigning
    {
        public TbltFileTransferSigning()
        {
            TbltFileTransferHeaderSenders = new HashSet<TbltFileTransferHeaderSender>();
            TbltFileTransferSigningHistories = new HashSet<TbltFileTransferSigningHistory>();
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
        public Guid? FileTransferHeaderSenderId { get; set; }

        public virtual TbltFileTransferHeaderSender? FileTransferHeaderSender { get; set; }
        public virtual TblmFileTransferSigningStatusFile? Status { get; set; }
        public virtual ICollection<TbltFileTransferHeaderSender> TbltFileTransferHeaderSenders { get; set; }
        public virtual ICollection<TbltFileTransferSigningHistory> TbltFileTransferSigningHistories { get; set; }
    }
}
