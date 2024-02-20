using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaFile
    {
        public TbltAlihMediaFile()
        {
            TbltAlihMediaItems = new HashSet<TbltAlihMediaItem>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? KodeSubPemberkasanId { get; set; }
        public Guid? AlihMediaHeaderSenderId { get; set; }
        public Guid? TingkatPerkembanganBerkasId { get; set; }
        public Guid? KategoriArsipId { get; set; }
        public Guid? KeteranganAksesKeamananId { get; set; }
        public Guid? InactiveArchiveManagementInventoryId { get; set; }
        public string? JenisSeriesArsip { get; set; }
        public string? UraianInformasi { get; set; }
        public string? NamaBerkas { get; set; }
        public string? LokasiTersimpan { get; set; }
        public string? Nominal { get; set; }
        public int? KurunWaktuBerkasMulai { get; set; }
        public int? KurunWaktuBerkasAkhir { get; set; }
        public int? JumlahBerkas { get; set; }
        public int? RetensiAktif { get; set; }
        public int? RetensiInaktif { get; set; }
        public string? KeteranganRetensi { get; set; }
        public string? Keterangan { get; set; }
        public string? RequestNumber { get; set; }
        public int? Sequence { get; set; }

        public virtual TbltAlihMediaHeaderSender? AlihMediaHeaderSender { get; set; }
        public virtual TbltInactiveArchiveManagementInventory? InactiveArchiveManagementInventory { get; set; }
        public virtual TblmKategoriArsip? KategoriArsip { get; set; }
        public virtual TblmKeteranganAksesKeamanan? KeteranganAksesKeamanan { get; set; }
        public virtual TblmKodeSubPemberkasan? KodeSubPemberkasan { get; set; }
        public virtual TblmTingkatPerkembanganDocument? TingkatPerkembanganBerkas { get; set; }
        public virtual ICollection<TbltAlihMediaItem> TbltAlihMediaItems { get; set; }
    }
}
