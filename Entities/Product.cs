using System;
using System.Collections.Generic;

namespace Upsert.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductReviews = new HashSet<ProductReview>();
        }

        public int ProductId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; }
    }
}
