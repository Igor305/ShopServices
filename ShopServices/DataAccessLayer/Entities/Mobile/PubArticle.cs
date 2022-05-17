using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class PubArticle
    {
        public PubArticle()
        {
            SubArticles = new HashSet<SubArticle>();
        }

        public int Id { get; set; }
        public int PublicationId { get; set; }
        public long PackNo { get; set; }
        public byte Rate { get; set; }
        public string Schema { get; set; }
        public string Table { get; set; }
        public long? LastSyncNo { get; set; }
        public byte StateId { get; set; }

        public virtual Publication Publication { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<SubArticle> SubArticles { get; set; }
    }
}
