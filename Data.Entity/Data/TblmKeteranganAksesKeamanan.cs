using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmKeteranganAksesKeamanan
    {
        public TblmKeteranganAksesKeamanan()
        {
            TbltActiveDocumentFiles = new HashSet<TbltActiveDocumentFile>();
            TbltAlihMediaFiles = new HashSet<TbltAlihMediaFile>();
            TbltFileTransferFiles = new HashSet<TbltFileTransferFile>();
            TbltInactiveActiveDocumentFiles = new HashSet<TbltInactiveActiveDocumentFile>();
            TbltInactiveArchiveManagementFiles = new HashSet<TbltInactiveArchiveManagementFile>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Keterangan { get; set; }
        public int? Hierarchy { get; set; }
        public string? Deskripsi { get; set; }
        public bool? ActiveStatus { get; set; }
        public bool? CanBeBorrowed { get; set; }

        public virtual ICollection<TbltActiveDocumentFile> TbltActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; }
        public virtual ICollection<TbltFileTransferFile> TbltFileTransferFiles { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentFile> TbltInactiveActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementFile> TbltInactiveArchiveManagementFiles { get; set; }
    }
}
