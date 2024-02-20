using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltInactiveArchiveManagementItem
    {
        public TbltInactiveArchiveManagementItem()
        {
            TbltAlihMediaItems = new HashSet<TbltAlihMediaItem>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? InactiveArchiveManagementFileId { get; set; }
        public Guid? KodeSubPemberkasanId { get; set; }
        public Guid? TingkatPerkembanganDokumenId { get; set; }
        public Guid? BentukItemId { get; set; }
        public string? NoItemArsip { get; set; }
        public string? UraianInformasi { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? Jumlah { get; set; }
        public string? FileNameUser { get; set; }
        public string? FileNameSystem { get; set; }
        public string? Keterangan { get; set; }
        public int? Sequence { get; set; }

        public virtual TblmBentukItem? BentukItem { get; set; }
        public virtual TbltInactiveArchiveManagementFile? InactiveArchiveManagementFile { get; set; }
        public virtual TblmKodeSubPemberkasan? KodeSubPemberkasan { get; set; }
        public virtual TblmTingkatPerkembanganDocument? TingkatPerkembanganDokumen { get; set; }
        public virtual ICollection<TbltAlihMediaItem> TbltAlihMediaItems { get; set; }
    }
}
