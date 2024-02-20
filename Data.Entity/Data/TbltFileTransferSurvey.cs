using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltFileTransferSurvey
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? FileTransferStatusFileId { get; set; }
        public string? NomorPermintaan { get; set; }
        public string? PelaksanaSurvey { get; set; }
        public DateTime? TanggalSurvey { get; set; }
        public string? PenanggungJawabFungsi { get; set; }
        public string? LokasiArsip { get; set; }
        public string? MediaArsip { get; set; }
        public int? Jumlah { get; set; }
        public int? KurunWaktu { get; set; }
        public string? SistemPenataan { get; set; }
        public Guid? BerkasArsipId { get; set; }
        public Guid? SaranaSimpanId { get; set; }
        public Guid? RetensiArsipId { get; set; }
        public Guid? RekomendasiArsipId { get; set; }
        public string? Catatan { get; set; }
        public string? FileNameSystem { get; set; }
        public string? FileNameUser { get; set; }
        public Guid? RcPenyimpananId { get; set; }
        public Guid? FileTransferHeaderSenderId { get; set; }
        public Guid? KondisiArsipId { get; set; }

        public virtual TblmKesesuaianDaftarFisikArsip? BerkasArsip { get; set; }
        public virtual TbltFileTransferHeaderSender? FileTransferHeaderSender { get; set; }
        public virtual TblmKondisiArsip? KondisiArsip { get; set; }
        public virtual TblmRcPenyimpanan? RcPenyimpanan { get; set; }
        public virtual TblmRekomendasiArsip? RekomendasiArsip { get; set; }
        public virtual TblmKesesuaianDaftarFisikArsip? RetensiArsip { get; set; }
        public virtual TblmKesesuaianDaftarFisikArsip? SaranaSimpan { get; set; }
    }
}
