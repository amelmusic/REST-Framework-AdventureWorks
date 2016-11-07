using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class ProductModelProductDescriptionCulture
    {
        public int ProductModelID { get; set; }
        public int ProductDescriptionID { get; set; }
        public string CultureID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Culture Culture { get; set; }
        public virtual ProductDescription ProductDescription { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
