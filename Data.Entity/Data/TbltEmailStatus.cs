using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltEmailStatus
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? FeatureName { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailSentTo { get; set; }
        public string? EmailStatus { get; set; }
        public string? Comments { get; set; }
    }
}
