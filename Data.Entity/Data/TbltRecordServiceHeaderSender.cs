using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltRecordServiceHeaderSender
    {
        public TbltRecordServiceHeaderSender()
        {
            TbltInactiveArchiveManagementHeaderSenders = new HashSet<TbltInactiveArchiveManagementHeaderSender>();
            TbltRecordServiceAttachments = new HashSet<TbltRecordServiceAttachment>();
            TbltRecordServiceFiles = new HashSet<TbltRecordServiceFile>();
            TbltRecordServiceHistories = new HashSet<TbltRecordServiceHistory>();
            TbltRecordServiceSignings = new HashSet<TbltRecordServiceSigning>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CompanyCode { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? NamaPimpinan { get; set; }
        public string? Alamat { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? ContactPersonMobileNumber { get; set; }
        public string? Referensi { get; set; }
        public Guid? TypeOfDuplicationId { get; set; }
        public string? RequestNumber { get; set; }
        public Guid? StatusId { get; set; }
        public string? SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? SubmitApprovedBy { get; set; }
        public DateTime? SubmitApprovedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime? AssignedDate { get; set; }
        public Guid? TransactionTypeId { get; set; }
        public string? UraianInformasi { get; set; }
        public string? NoSkOrganisasi { get; set; }
        public string? Kbo { get; set; }
        public string? JenisSeriesArsip { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? BorrowStartDate { get; set; }
        public Guid? JustifikasiAksesId { get; set; }
        public string? CompanyCodeOwner { get; set; }

        public virtual TblmJustifikasiAkse? JustifikasiAkses { get; set; }
        public virtual TblmRecordServicesStatusFile? Status { get; set; }
        public virtual TblmRecordServiceTransactionType? TransactionType { get; set; }
        public virtual TblmRecordServiceRequestDuplicationType? TypeOfDuplication { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementHeaderSender> TbltInactiveArchiveManagementHeaderSenders { get; set; }
        public virtual ICollection<TbltRecordServiceAttachment> TbltRecordServiceAttachments { get; set; }
        public virtual ICollection<TbltRecordServiceFile> TbltRecordServiceFiles { get; set; }
        public virtual ICollection<TbltRecordServiceHistory> TbltRecordServiceHistories { get; set; }
        public virtual ICollection<TbltRecordServiceSigning> TbltRecordServiceSignings { get; set; }
    }
}
