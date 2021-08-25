using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class FoodType
    {
        public FoodType()
        {
            Meals = new HashSet<Meal>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
