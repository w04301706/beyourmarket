using System;
using System.Collections.Generic;

namespace BeYourMarket.Model.Models
{
    public partial class ListingReview : Repository.Pattern.Ef6.Entity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int ListingID { get; set; }
        public int OrderID { get; set; }
        public string UserFrom { get; set; }
        public string UserTo { get; set; }
        public bool Active { get; set; }
        public bool Enabled { get; set; }
        public bool Spam { get; set; }
        public System.DateTime Created { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual Order Order { get; set; }
    }
}
