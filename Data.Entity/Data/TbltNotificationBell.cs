using System;
using System.Collections.Generic;

namespace Data.Entity.Data
{
    public partial class TbltNotificationBell
    {
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? HeaderId { get; set; }
        public Guid? StatusId { get; set; }
        public string? FeatureName { get; set; }
        public string? SenderName { get; set; }
        public string? SentTo { get; set; }
        public bool? StatusNotifRead { get; set; }
    }
}
