using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmKodePokokPemberkasan
    {
        public TblmKodePokokPemberkasan()
        {
            TblmKodeSubPemberkasans = new HashSet<TblmKodeSubPemberkasan>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Kode { get; set; }
        public string? PokokPermasalahan { get; set; }

        public virtual ICollection<TblmKodeSubPemberkasan> TblmKodeSubPemberkasans { get; set; }
    }
}
