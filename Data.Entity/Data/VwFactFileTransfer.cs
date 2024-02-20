using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class VwFactFileTransfer
    {
        public Guid FileTranferItemId { get; set; }
        public Guid FileTransferFileId { get; set; }
        public Guid FileTranferHeaderId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? Tanggal { get; set; }
        public int? Yyyy { get; set; }
        public int? Mm { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? CompanyCode { get; set; }
        public string? Direktorat { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public string? UraianInformasi { get; set; }
        public string? FileNameUser { get; set; }
        public string? TingkatPerkembanganDocument { get; set; }
        public string? NamaBerkas { get; set; }
        public string? JenisSeriesArsip { get; set; }
        public int? KurunWaktuBerkasMulai { get; set; }
        public int? KurunWaktuBerkasAkhir { get; set; }
        public int? RetensiAktif { get; set; }
        public int? RetensiInaktif { get; set; }
        public string? KodeSubPemberkasan { get; set; }
        public string? KategoriArsip { get; set; }
        public string? RequestNumber { get; set; }
        public string? StepCode { get; set; }
        public string? StatusName { get; set; }
    }
}
