﻿using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltAlihMediaFileSigning
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Username { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? AlihMediaSigningId { get; set; }
        public string? RoleName { get; set; }
        public bool? HasSign { get; set; }

        public virtual TbltAlihMediaSigning? AlihMediaSigning { get; set; }
        public virtual TblmRole? Role { get; set; }
    }
}
