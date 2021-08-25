using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Color
    {
        public Color()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Color1 { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
