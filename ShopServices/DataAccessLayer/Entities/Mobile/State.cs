using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class State
    {
        public State()
        {
            Distributors = new HashSet<Distributor>();
            PubArticles = new HashSet<PubArticle>();
            Publications = new HashSet<Publication>();
            Publishers = new HashSet<Publisher>();
            SubArticles = new HashSet<SubArticle>();
            Subscribers = new HashSet<Subscriber>();
            Subscriptions = new HashSet<Subscription>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Distributor> Distributors { get; set; }
        public virtual ICollection<PubArticle> PubArticles { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<SubArticle> SubArticles { get; set; }
        public virtual ICollection<Subscriber> Subscribers { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
