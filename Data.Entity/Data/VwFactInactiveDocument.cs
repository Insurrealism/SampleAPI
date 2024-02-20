using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class VwFactInactiveDocument
    {
        public Guid InactiveItemId { get; set; }
        public Guid InactiveFileId { get; set; }
        public Guid InactiveHeaderId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? Yyyy { get; set; }
        public int? Mm { get; set; }
        public string? CompanyCode { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public string? NamaBerkas { get; set; }
        public string? UraianInformasi { get; set; }
        public string? KategoriArsip { get; set; }
        public string? JenisSeriesArsip { get; set; }
        public string? FileNameUser { get; set; }
        public string? TingkatPerkembanganDokumen { get; set; }
        public string? BentukItem { get; set; }
        public string? KodeSubPemberkasan { get; set; }
        public string? NamaSubPemberkasan { get; set; }
        public string? Keterangan { get; set; }
        public int? KurunWaktuBerkasMulai { get; set; }
        public int? KurunWaktuBerkasAkhir { get; set; }
        public int? RetensiAktif { get; set; }
        public int? RetensiInaktif { get; set; }
        public string? RequestNumber { get; set; }
        public bool? StatusAlihMedia { get; set; }
        public bool? CanBeBorrowed { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
    }
}
