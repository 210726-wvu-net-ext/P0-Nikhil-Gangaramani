using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Species
    {
        public Species()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Species1 { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
