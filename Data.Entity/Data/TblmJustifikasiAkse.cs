using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmJustifikasiAkse
    {
        public TblmJustifikasiAkse()
        {
            TbltRecordServiceHeaderSenders = new HashSet<TbltRecordServiceHeaderSender>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Hierarchy { get; set; }
        public string? Nama { get; set; }
        public string? Deskrepsi { get; set; }

        public virtual ICollection<TbltRecordServiceHeaderSender> TbltRecordServiceHeaderSenders { get; set; }
    }
}
