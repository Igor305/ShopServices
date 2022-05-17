using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class SubEventHistory
    {
        public int SubArticleId { get; set; }
        public long FromPackNo { get; set; }
        public long ToPackNo { get; set; }
        public long? FromVersion { get; set; }
        public long? ToVersion { get; set; }
        public int? Rows { get; set; }
        public TimeSpan? ElapsedTime { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }

        public virtual SubArticle SubArticle { get; set; }
    }
}
