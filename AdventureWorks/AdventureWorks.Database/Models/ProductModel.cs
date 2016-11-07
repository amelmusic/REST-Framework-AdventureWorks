using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            this.Products = new List<Product>();
            this.ProductModelIllustrations = new List<ProductModelIllustration>();
            this.ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public string Instructions { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}
