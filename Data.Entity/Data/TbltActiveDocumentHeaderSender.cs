using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltActiveDocumentHeaderSender
    {
        public TbltActiveDocumentHeaderSender()
        {
            TbltActiveDocumentFiles = new HashSet<TbltActiveDocumentFile>();
            TbltActiveDocumentHistories = new HashSet<TbltActiveDocumentHistory>();
            TbltInactiveActiveDocumentHeaderSenders = new HashSet<TbltInactiveActiveDocumentHeaderSender>();
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

        public virtual TblmActiveDocumentStatusFile? Status { get; set; }
        public virtual ICollection<TbltActiveDocumentFile> TbltActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltActiveDocumentHistory> TbltActiveDocumentHistories { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentHeaderSender> TbltInactiveActiveDocumentHeaderSenders { get; set; }
    }
}
