using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltInactiveArchiveManagementHeaderSender
    {
        public TbltInactiveArchiveManagementHeaderSender()
        {
            TbltAlihMediaInventories = new HashSet<TbltAlihMediaInventory>();
            TbltInactiveArchiveManagementFiles = new HashSet<TbltInactiveArchiveManagementFile>();
            TbltInactiveArchiveManagementHistories = new HashSet<TbltInactiveArchiveManagementHistory>();
            TbltRecordServiceFiles = new HashSet<TbltRecordServiceFile>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? RecordServiceHeaderSenderId { get; set; }
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
        public bool? CanBeBorrowed { get; set; }
        public bool? StatusAlihMedia { get; set; }
        public Guid? AlihMediaHeaderSenderId { get; set; }
        public int? JumlahBerkas { get; set; }
        public Guid? FileTransferHeaderSenderId { get; set; }

        public virtual TbltAlihMediaHeaderSender? AlihMediaHeaderSender { get; set; }
        public virtual TbltFileTransferHeaderSender? FileTransferHeaderSender { get; set; }
        public virtual TbltRecordServiceHeaderSender? RecordServiceHeaderSender { get; set; }
        public virtual TblmInactiveArchiveManagementStatusFile? Status { get; set; }
        public virtual ICollection<TbltAlihMediaInventory> TbltAlihMediaInventories { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementFile> TbltInactiveArchiveManagementFiles { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementHistory> TbltInactiveArchiveManagementHistories { get; set; }
        public virtual ICollection<TbltRecordServiceFile> TbltRecordServiceFiles { get; set; }
    }
}
