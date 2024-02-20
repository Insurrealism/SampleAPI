using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmKodeKlasifikasiPemberkasan
    {
        public TblmKodeKlasifikasiPemberkasan()
        {
            TblmSubPermasalahans = new HashSet<TblmSubPermasalahan>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? KodeSubPemberkasanId { get; set; }
        public string? Kode { get; set; }
        public string? Deskripsi { get; set; }
        public bool? ActiveStatus { get; set; }

        public virtual TblmKodeSubPemberkasan? KodeSubPemberkasan { get; set; }
        public virtual ICollection<TblmSubPermasalahan> TblmSubPermasalahans { get; set; }
    }
}
