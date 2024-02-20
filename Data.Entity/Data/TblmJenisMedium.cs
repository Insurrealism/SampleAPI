using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmJenisMedium
    {
        public TblmJenisMedium()
        {
            TbltAlihMediaHeaderSenders = new HashSet<TbltAlihMediaHeaderSender>();
            TbltAlihMediaProposals = new HashSet<TbltAlihMediaProposal>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TbltAlihMediaHeaderSender> TbltAlihMediaHeaderSenders { get; set; }
        public virtual ICollection<TbltAlihMediaProposal> TbltAlihMediaProposals { get; set; }
    }
}
