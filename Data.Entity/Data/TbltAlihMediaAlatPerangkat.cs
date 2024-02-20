using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaAlatPerangkat
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? PerangkatId { get; set; }
        public Guid? AlihMediaHeaderSenderId { get; set; }

        public virtual TbltAlihMediaHeaderSender? AlihMediaHeaderSender { get; set; }
        public virtual TblmPerangkat? Perangkat { get; set; }
    }
}
