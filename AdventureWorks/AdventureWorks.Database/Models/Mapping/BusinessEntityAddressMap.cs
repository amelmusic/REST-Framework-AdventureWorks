using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class BusinessEntityAddressMap : EntityTypeConfiguration<BusinessEntityAddress>
    {
        public BusinessEntityAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.AddressID, t.AddressTypeID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BusinessEntityAddress", "Person");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.AddressType)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressTypeID);
            this.HasRequired(t => t.BusinessEntity)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
