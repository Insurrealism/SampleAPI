using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmProvinsi
    {
        public TblmProvinsi()
        {
            TblmKotaKabupatens = new HashSet<TblmKotaKabupaten>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TblmKotaKabupaten> TblmKotaKabupatens { get; set; }
    }
}
