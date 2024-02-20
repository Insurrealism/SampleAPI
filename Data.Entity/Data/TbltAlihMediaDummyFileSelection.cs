using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaDummyFileSelection
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Username { get; set; }
        public Guid? InactiveArchiveManagementId { get; set; }

        public virtual TbltInactiveArchiveManagementFile? InactiveArchiveManagement { get; set; }
    }
}
