using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Subscription
    {
        public Subscription()
        {
            SubArticles = new HashSet<SubArticle>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int SubscriberId { get; set; }
        public int PublicationId { get; set; }
        public string Schema { get; set; }
        public string Fg { get; set; }
        public long PackNo { get; set; }
        public DateTime? LastEvent { get; set; }
        public byte StateId { get; set; }

        public virtual Publication Publication { get; set; }
        public virtual State State { get; set; }
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<SubArticle> SubArticles { get; set; }
    }
}
