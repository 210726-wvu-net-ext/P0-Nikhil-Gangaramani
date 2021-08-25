using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Cat
    {
        public Cat()
        {
            Meals = new HashSet<Meal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? DoB { get; set; }
        public int FurType { get; set; }
        public int CatType { get; set; }

        public virtual CatType CatTypeNavigation { get; set; }
        public virtual FurType FurTypeNavigation { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
