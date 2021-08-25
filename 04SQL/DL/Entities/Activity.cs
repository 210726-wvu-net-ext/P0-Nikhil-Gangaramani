using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Activity1 { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
