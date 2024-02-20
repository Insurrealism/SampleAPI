﻿using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmRecordServiceTransactionType
    {
        public TblmRecordServiceTransactionType()
        {
            TbltRecordServiceHeaderSenders = new HashSet<TbltRecordServiceHeaderSender>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }
        public bool? IsReturned { get; set; }

        public virtual ICollection<TbltRecordServiceHeaderSender> TbltRecordServiceHeaderSenders { get; set; }
    }
}
