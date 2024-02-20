using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmBentukItem
    {
        public TblmBentukItem()
        {
            TbltActiveDocumentItems = new HashSet<TbltActiveDocumentItem>();
            TbltAlihMediaItems = new HashSet<TbltAlihMediaItem>();
            TbltFileTransferItems = new HashSet<TbltFileTransferItem>();
            TbltInactiveActiveDocumentItems = new HashSet<TbltInactiveActiveDocumentItem>();
            TbltInactiveArchiveManagementItems = new HashSet<TbltInactiveArchiveManagementItem>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TbltActiveDocumentItem> TbltActiveDocumentItems { get; set; }
        public virtual ICollection<TbltAlihMediaItem> TbltAlihMediaItems { get; set; }
        public virtual ICollection<TbltFileTransferItem> TbltFileTransferItems { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentItem> TbltInactiveActiveDocumentItems { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementItem> TbltInactiveArchiveManagementItems { get; set; }
    }
}
