using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltInactiveArchiveManagementInventory
    {
        public TbltInactiveArchiveManagementInventory()
        {
            TbltAlihMediaFiles = new HashSet<TbltAlihMediaFile>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CompanyCode { get; set; }
        public string? DirektoratId { get; set; }
        public string? Direktorat { get; set; }
        public string? FungsiId { get; set; }
        public string? Fungsi { get; set; }
        public string? Kbo { get; set; }
        public Guid? InactiveArchiveManagementFileId { get; set; }
        public Guid? GedungId { get; set; }
        public Guid? RuanganId { get; set; }
        public Guid? RakId { get; set; }
        public Guid? AmbalanId { get; set; }
        public string? Boks { get; set; }
        public string? Folder { get; set; }
        public string? Keterangan { get; set; }
        public int? Sequence { get; set; }

        public virtual TblmAmbalan? Ambalan { get; set; }
        public virtual TblmGedung? Gedung { get; set; }
        public virtual TbltInactiveArchiveManagementFile? InactiveArchiveManagementFile { get; set; }
        public virtual TblmRak? Rak { get; set; }
        public virtual TblmRuangan? Ruangan { get; set; }
        public virtual ICollection<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; }
    }
}
