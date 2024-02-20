using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmRcPenyimpanan
    {
        public TblmRcPenyimpanan()
        {
            TbltFileTransferSurveys = new HashSet<TbltFileTransferSurvey>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? RecordPenyimpanan { get; set; }

        public virtual ICollection<TbltFileTransferSurvey> TbltFileTransferSurveys { get; set; }
    }
}
