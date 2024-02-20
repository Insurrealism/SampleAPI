using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltInactiveActiveDocumentHeaderSender
    {
        public TbltInactiveActiveDocumentHeaderSender()
        {
            TbltInactiveActiveDocumentFiles = new HashSet<TbltInactiveActiveDocumentFile>();
            TbltInactiveActiveDocumentHistories = new HashSet<TbltInactiveActiveDocumentHistory>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime? AssignedDate { get; set; }
        public Guid? StatusId { get; set; }
        public string? RequestNumber { get; set; }
        public string? CompanyCode { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? Kbo { get; set; }
        public string? NoSkOrganisasi { get; set; }
        public string? NamaPimpinan { get; set; }
        public string? Alamat { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? ContactPersonMobileNumber { get; set; }
        public Guid? ActiveDocumentHeaderSenderId { get; set; }

        public virtual TbltActiveDocumentHeaderSender? ActiveDocumentHeaderSender { get; set; }
        public virtual TblmInactiveActiveDocumentStatusFile? Status { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentFile> TbltInactiveActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentHistory> TbltInactiveActiveDocumentHistories { get; set; }
    }
}
