using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Publisher
    {
        public Publisher()
        {
            Publications = new HashSet<Publication>();
        }

        public int Id { get; set; }
        public byte Self { get; set; }
        public string Description { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte StateId { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
    }
}
