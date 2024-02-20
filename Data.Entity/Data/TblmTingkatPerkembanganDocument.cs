using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmTingkatPerkembanganDocument
    {
        public TblmTingkatPerkembanganDocument()
        {
            TbltActiveDocumentFiles = new HashSet<TbltActiveDocumentFile>();
            TbltActiveDocumentItems = new HashSet<TbltActiveDocumentItem>();
            TbltAlihMediaFiles = new HashSet<TbltAlihMediaFile>();
            TbltAlihMediaItems = new HashSet<TbltAlihMediaItem>();
            TbltFileTransferFiles = new HashSet<TbltFileTransferFile>();
            TbltFileTransferItems = new HashSet<TbltFileTransferItem>();
            TbltInactiveActiveDocumentFiles = new HashSet<TbltInactiveActiveDocumentFile>();
            TbltInactiveActiveDocumentItems = new HashSet<TbltInactiveActiveDocumentItem>();
            TbltInactiveArchiveManagementFiles = new HashSet<TbltInactiveArchiveManagementFile>();
            TbltInactiveArchiveManagementItems = new HashSet<TbltInactiveArchiveManagementItem>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TbltActiveDocumentFile> TbltActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltActiveDocumentItem> TbltActiveDocumentItems { get; set; }
        public virtual ICollection<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; }
        public virtual ICollection<TbltAlihMediaItem> TbltAlihMediaItems { get; set; }
        public virtual ICollection<TbltFileTransferFile> TbltFileTransferFiles { get; set; }
        public virtual ICollection<TbltFileTransferItem> TbltFileTransferItems { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentFile> TbltInactiveActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentItem> TbltInactiveActiveDocumentItems { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementFile> TbltInactiveArchiveManagementFiles { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementItem> TbltInactiveArchiveManagementItems { get; set; }
    }
}
