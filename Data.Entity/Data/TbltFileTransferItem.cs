using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltFileTransferItem
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? FileTransferFileId { get; set; }
        public Guid? BentukItemId { get; set; }
        public string? NoItemArsip { get; set; }
        public string? UraianInformasi { get; set; }
        public DateTime? Tanggal { get; set; }
        public Guid? TingkatPerkembanganDokumenId { get; set; }
        public int? Jumlah { get; set; }
        public string? FileNameSystem { get; set; }
        public string? FileNameUser { get; set; }
        public string? Keterangan { get; set; }
        public int? Sequence { get; set; }

        public virtual TblmBentukItem? BentukItem { get; set; }
        public virtual TbltFileTransferFile? FileTransferFile { get; set; }
        public virtual TblmTingkatPerkembanganDocument? TingkatPerkembanganDokumen { get; set; }
    }
}
