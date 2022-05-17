using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class SubArticle
    {
        public SubArticle()
        {
            SubEventHistories = new HashSet<SubEventHistory>();
        }

        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public int PubArticleId { get; set; }
        public byte Rate { get; set; }
        public string Schema { get; set; }
        public string Table { get; set; }
        public long PackNo { get; set; }
        public long? LastSyncNo { get; set; }
        public byte StateId { get; set; }

        public virtual PubArticle PubArticle { get; set; }
        public virtual State State { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual ICollection<SubEventHistory> SubEventHistories { get; set; }
    }
}
