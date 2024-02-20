using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TblmKesesuaianDaftarFisikArsip
    {
        public TblmKesesuaianDaftarFisikArsip()
        {
            TbltFileTransferSurveyBerkasArsips = new HashSet<TbltFileTransferSurvey>();
            TbltFileTransferSurveyRetensiArsips = new HashSet<TbltFileTransferSurvey>();
            TbltFileTransferSurveySaranaSimpans = new HashSet<TbltFileTransferSurvey>();
        }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Kesesuaian { get; set; }

        public virtual ICollection<TbltFileTransferSurvey> TbltFileTransferSurveyBerkasArsips { get; set; }
        public virtual ICollection<TbltFileTransferSurvey> TbltFileTransferSurveyRetensiArsips { get; set; }
        public virtual ICollection<TbltFileTransferSurvey> TbltFileTransferSurveySaranaSimpans { get; set; }
    }
}
