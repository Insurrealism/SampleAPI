using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class VwFactActiveDocument
    {
        public Guid ActiveDocumentItemId { get; set; }
        public Guid ActiveDocumentFileId { get; set; }
        public Guid ActiveDocumentHeaderSenderId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? Yyyy { get; set; }
        public int? Mm { get; set; }
        public string? UraianInformasi { get; set; }
        public string? FileNameUser { get; set; }
        public string? TingkatDocument { get; set; }
        public string? KategoriArsip { get; set; }
        public string? KodeSubPemberkasan { get; set; }
        public string? DescSubPemberkasan { get; set; }
        public string? NamaBerkas { get; set; }
        public int? KurunWaktuBerkasMulai { get; set; }
        public int? KurunWaktuBerkasAkhir { get; set; }
        public int? RetensiAktif { get; set; }
        public string? RetensiAktifText { get; set; }
        public int? RetensiInaktif { get; set; }
        public string? RetensiInaktifText { get; set; }
        public string? KeteranganRetensi { get; set; }
        public string? StatusFile { get; set; }
        public string? CompanyCode { get; set; }
        public string? Fungsi { get; set; }
        public string? Direktorat { get; set; }
        public string? Kbo { get; set; }
    }
}
