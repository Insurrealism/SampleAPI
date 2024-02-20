using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaHeaderSender
    {
        public TbltAlihMediaHeaderSender()
        {
            TbltAlihMediaAlatPerangkats = new HashSet<TbltAlihMediaAlatPerangkat>();
            TbltAlihMediaFiles = new HashSet<TbltAlihMediaFile>();
            TbltAlihMediaHistories = new HashSet<TbltAlihMediaHistory>();
            TbltAlihMediaInventories = new HashSet<TbltAlihMediaInventory>();
            TbltAlihMediaProposals = new HashSet<TbltAlihMediaProposal>();
            TbltAlihMediaSignings = new HashSet<TbltAlihMediaSigning>();
            TbltInactiveArchiveManagementHeaderSenders = new HashSet<TbltInactiveArchiveManagementHeaderSender>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? InactiveArchiveManagementInventoryId { get; set; }
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
        public Guid? FileTransferHeaderSenderId { get; set; }
        public int? JumlahBerkas { get; set; }
        public Guid? FormatDigitalId { get; set; }
        public string? InventoryNumber { get; set; }
        public string? TempatPelaksanaan { get; set; }
        public string? CompanyBerkasId { get; set; }
        public string? CompanyBerkas { get; set; }
        public string? DirektoratBerkasId { get; set; }
        public string? DirektoratBerkas { get; set; }
        public string? FungsiBerkasId { get; set; }
        public string? FungsiBerkas { get; set; }

        public virtual TbltFileTransferHeaderSender? FileTransferHeaderSender { get; set; }
        public virtual TblmJenisMedium? FormatDigital { get; set; }
        public virtual TblmAlihMediaStatusFile? Status { get; set; }
        public virtual ICollection<TbltAlihMediaAlatPerangkat> TbltAlihMediaAlatPerangkats { get; set; }
        public virtual ICollection<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; }
        public virtual ICollection<TbltAlihMediaHistory> TbltAlihMediaHistories { get; set; }
        public virtual ICollection<TbltAlihMediaInventory> TbltAlihMediaInventories { get; set; }
        public virtual ICollection<TbltAlihMediaProposal> TbltAlihMediaProposals { get; set; }
        public virtual ICollection<TbltAlihMediaSigning> TbltAlihMediaSignings { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementHeaderSender> TbltInactiveArchiveManagementHeaderSenders { get; set; }
    }
}
