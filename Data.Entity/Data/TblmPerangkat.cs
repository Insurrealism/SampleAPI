using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmPerangkat
    {
        public TblmPerangkat()
        {
            TbltAlihMediaAlatPerangkats = new HashSet<TbltAlihMediaAlatPerangkat>();
            TbltAlihMediaProposals = new HashSet<TbltAlihMediaProposal>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }
        public string? Deskripsi { get; set; }
        public bool? ActiveStatus { get; set; }
        public string? CompanyCode { get; set; }

        public virtual ICollection<TbltAlihMediaAlatPerangkat> TbltAlihMediaAlatPerangkats { get; set; }
        public virtual ICollection<TbltAlihMediaProposal> TbltAlihMediaProposals { get; set; }
    }
}
