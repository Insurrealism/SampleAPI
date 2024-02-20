using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmFeature
    {
        public TblmFeature()
        {
            TblmRoleFeatures = new HashSet<TblmRoleFeature>();
        }

        public string Id { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Code { get; set; }
        public string? ParentFeatureCode { get; set; }
        public string? FeatureName { get; set; }
        public string? AreaName { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? MenuIcon { get; set; }
        public bool? IsMenu { get; set; }
        public string? Description { get; set; }
        public int? Sequence { get; set; }
        public int? SequenceChild { get; set; }
        public string? SubMenuIcon { get; set; }
        public string? SubMenuDesc { get; set; }
        public string? MenuLink { get; set; }
        public bool? IsCatalog { get; set; }

        public virtual ICollection<TblmRoleFeature> TblmRoleFeatures { get; set; }
    }
}
