using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaProposal
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? JumlahHalaman { get; set; }
        public Guid? AlihMediaHeaderSenderId { get; set; }
        public Guid? AlihMediaFileId { get; set; }
        public Guid? JenisMediaId { get; set; }
        public Guid? PerangkatId { get; set; }
        public string? Biaya { get; set; }
        public DateTime? WaktuAwal { get; set; }
        public string? Keterangan { get; set; }
        public Guid? JenisMediaMenjadiId { get; set; }
        public DateTime? WaktuAkhir { get; set; }

        public virtual TbltFileTransferFile? AlihMediaFile { get; set; }
        public virtual TbltAlihMediaHeaderSender? AlihMediaHeaderSender { get; set; }
        public virtual TblmJenisMedium? JenisMedia { get; set; }
        public virtual TblmPerangkat? Perangkat { get; set; }
    }
}
