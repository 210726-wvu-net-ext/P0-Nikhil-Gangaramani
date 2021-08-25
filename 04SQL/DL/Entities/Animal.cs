using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Animal
    {
        public Animal()
        {
            LikesNavigation = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Species { get; set; }
        public int Color { get; set; }
        public int Likes { get; set; }

        public virtual Color ColorNavigation { get; set; }
        public virtual Species SpeciesNavigation { get; set; }
        public virtual ICollection<Like> LikesNavigation { get; set; }
    }
}
