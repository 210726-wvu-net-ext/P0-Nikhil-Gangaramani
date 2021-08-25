using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Meal
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int FoodType { get; set; }
        public int CatId { get; set; }

        public virtual Cat Cat { get; set; }
        public virtual FoodType FoodTypeNavigation { get; set; }
    }
}
