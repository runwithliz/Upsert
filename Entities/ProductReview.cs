using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Upsert.Entities
{
    public partial class ProductReview
    {
        public int ProductReviewId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
        
        public virtual User User { get; set; }
    }
}
