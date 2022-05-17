using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int DistributorId { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte StateId { get; set; }

        public virtual Distributor Distributor { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
