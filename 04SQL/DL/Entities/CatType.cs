using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class CatType
    {
        public CatType()
        {
            Cats = new HashSet<Cat>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
    }
}
