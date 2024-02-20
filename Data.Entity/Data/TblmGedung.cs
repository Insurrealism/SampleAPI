using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmGedung
    {
        public TblmGedung()
        {
            TblmRuangans = new HashSet<TblmRuangan>();
            TbltInactiveArchiveManagementInventories = new HashSet<TbltInactiveArchiveManagementInventory>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }
        public string? Deskripsi { get; set; }
        public string? Alamat { get; set; }
        public bool? ActiveStatus { get; set; }
        public string? CompanyCode { get; set; }

        public virtual ICollection<TblmRuangan> TblmRuangans { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementInventory> TbltInactiveArchiveManagementInventories { get; set; }
    }
}
