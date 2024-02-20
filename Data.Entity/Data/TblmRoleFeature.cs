using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmRoleFeature
    {
        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? FeatureId { get; set; }
        public Guid? RoleId { get; set; }
        public bool IsCreate { get; set; }
        public bool IsRead { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }

        public virtual TblmFeature? Feature { get; set; }
        public virtual TblmRole? Role { get; set; }
    }
}
