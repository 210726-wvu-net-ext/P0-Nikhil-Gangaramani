using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Like
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnimalId { get; set; }
        public int ActivityId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Animal Animal { get; set; }
    }
}
