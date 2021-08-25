using System;
using System.Collections.Generic;

namespace Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
        public int RestaurantId { get; set; }

        public Review()
        {
            
        }

        public Review(int userid, string comments,int rating,int restauraintid )
        {
            this.UserId = userid;
            this.RestaurantId=restauraintid;
            this.Comments = comments;
            this.Rating=rating;
        }
    }
}