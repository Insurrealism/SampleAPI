using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class VwFactAlihMedium
    {
        public Guid AlihMediaItemId { get; set; }
        public Guid AlihMediaFileId { get; set; }
        public Guid AlihMediaHeaderId { get; set; }
        public string? CompanyCode { get; set; }
        public string? Direktorat { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? Yyyy { get; set; }
        public int? Mm { get; set; }
        public string? UraianInformasi { get; set; }
        public string? NamaBerkas { get; set; }
        public string? BentukItem { get; set; }
        public string? TingkatPerkembanganDokumen { get; set; }
        public int? Jumlah { get; set; }
        public string? FileNameUser { get; set; }
        public string? KodeSubPemberkasanId { get; set; }
        public string? Keterangan { get; set; }
        public string? KategoriArsip { get; set; }
        public int? KurunWaktuBerkasMulai { get; set; }
        public int? KurunWaktuBerkasAkhir { get; set; }
        public int? RetensiAktif { get; set; }
        public int? RetensiInaktif { get; set; }
        public string? KeteranganRetensi { get; set; }
        public string? AksesKeamanan { get; set; }
        public string? StatusName { get; set; }
    }
}
