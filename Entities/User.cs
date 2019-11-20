using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Upsert.Entities
{
    public partial class User
    {
        public User()
        {
            ProductReviews = new HashSet<ProductReview>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }

        [JsonIgnore]
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
    }
}
