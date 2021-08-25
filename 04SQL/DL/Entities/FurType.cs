using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class FurType
    {
        public FurType()
        {
            Cats = new HashSet<Cat>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
    }
}
