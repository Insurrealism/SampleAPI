using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltFileTransferHeaderSender
    {
        public TbltFileTransferHeaderSender()
        {
            TbltAlihMediaHeaderSenders = new HashSet<TbltAlihMediaHeaderSender>();
            TbltFileTransferFiles = new HashSet<TbltFileTransferFile>();
            TbltFileTransferHistories = new HashSet<TbltFileTransferHistory>();
            TbltFileTransferSignings = new HashSet<TbltFileTransferSigning>();
            TbltFileTransferSurveys = new HashSet<TbltFileTransferSurvey>();
            TbltInactiveArchiveManagementHeaderSenders = new HashSet<TbltInactiveArchiveManagementHeaderSender>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? StatusId { get; set; }
        public string? RequestNumber { get; set; }
        public string? CompanyCode { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public string? NoSkOrganisasi { get; set; }
        public string? NamaPimpinan { get; set; }
        public string? Alamat { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? ContactPersonMobileNumber { get; set; }
        public string? SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string? AssignedBy { get; set; }
        public string? SurveyBy { get; set; }
        public DateTime? SurveyDate { get; set; }
        public Guid? FileTransferSigningId { get; set; }

        public virtual TbltFileTransferSigning? FileTransferSigning { get; set; }
        public virtual TblmFileTransferStatusFile? Status { get; set; }
        public virtual ICollection<TbltAlihMediaHeaderSender> TbltAlihMediaHeaderSenders { get; set; }
        public virtual ICollection<TbltFileTransferFile> TbltFileTransferFiles { get; set; }
        public virtual ICollection<TbltFileTransferHistory> TbltFileTransferHistories { get; set; }
        public virtual ICollection<TbltFileTransferSigning> TbltFileTransferSignings { get; set; }
        public virtual ICollection<TbltFileTransferSurvey> TbltFileTransferSurveys { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementHeaderSender> TbltInactiveArchiveManagementHeaderSenders { get; set; }
    }
}
