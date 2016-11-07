using AdventureWorks.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureWorks.Services.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.BusinessEntityID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountNumber)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PurchasingWebServiceURL)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("Vendor", "Purchasing");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreditRating).HasColumnName("CreditRating");
            this.Property(t => t.PreferredVendorStatus).HasColumnName("PreferredVendorStatus");
            this.Property(t => t.ActiveFlag).HasColumnName("ActiveFlag");
            this.Property(t => t.PurchasingWebServiceURL).HasColumnName("PurchasingWebServiceURL");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            //// Relationships
            //this.HasRequired(t => t.BusinessEntity)
            //    .WithOptional(t => t.Vendor);
            this.Ignore(t => t.CreatedDate);
        }
    }
}
