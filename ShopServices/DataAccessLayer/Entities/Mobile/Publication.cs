using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Publication
    {
        public Publication()
        {
            PubArticles = new HashSet<PubArticle>();
            Subscriptions = new HashSet<Subscription>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
        public string Schema { get; set; }
        public string Fg { get; set; }
        public long PackNo { get; set; }
        public DateTime? LastEvent { get; set; }
        public byte StateId { get; set; }

        public virtual Publisher Publisher { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<PubArticle> PubArticles { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
