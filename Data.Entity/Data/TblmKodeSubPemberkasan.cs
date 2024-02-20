using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmKodeSubPemberkasan
    {
        public TblmKodeSubPemberkasan()
        {
            TblmKodeKlasifikasiPemberkasans = new HashSet<TblmKodeKlasifikasiPemberkasan>();
            TbltActiveDocumentFiles = new HashSet<TbltActiveDocumentFile>();
            TbltAlihMediaFiles = new HashSet<TbltAlihMediaFile>();
            TbltFileTransferFiles = new HashSet<TbltFileTransferFile>();
            TbltInactiveActiveDocumentFiles = new HashSet<TbltInactiveActiveDocumentFile>();
            TbltInactiveArchiveManagementFiles = new HashSet<TbltInactiveArchiveManagementFile>();
            TbltInactiveArchiveManagementItems = new HashSet<TbltInactiveArchiveManagementItem>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? KodePokokPemberkasanId { get; set; }
        public string? Kode { get; set; }
        public string? Deskripsi { get; set; }
        public bool? ActiveIsPermanen { get; set; }
        public bool? ActiveIsPermanenTerbatas { get; set; }
        public bool? ActiveIsOthers { get; set; }
        public int? MasaRetensiActive { get; set; }
        public bool? InactiveIsPermanen { get; set; }
        public bool? InactiveIsPermanenTerbatas { get; set; }
        public bool? InactiveIsOthers { get; set; }
        public int? MasaRetensiInactive { get; set; }
        public string? Keterangan { get; set; }
        public bool? ActiveStatus { get; set; }

        public virtual TblmKodePokokPemberkasan? KodePokokPemberkasan { get; set; }
        public virtual ICollection<TblmKodeKlasifikasiPemberkasan> TblmKodeKlasifikasiPemberkasans { get; set; }
        public virtual ICollection<TbltActiveDocumentFile> TbltActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; }
        public virtual ICollection<TbltFileTransferFile> TbltFileTransferFiles { get; set; }
        public virtual ICollection<TbltInactiveActiveDocumentFile> TbltInactiveActiveDocumentFiles { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementFile> TbltInactiveArchiveManagementFiles { get; set; }
        public virtual ICollection<TbltInactiveArchiveManagementItem> TbltInactiveArchiveManagementItems { get; set; }
    }
}
