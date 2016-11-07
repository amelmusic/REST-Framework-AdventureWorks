using AdventureWorks.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureWorks.Services.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.AccountNumber)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Customer", "Sales");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany()
                .HasForeignKey(d => d.PersonID);
            //this.HasOptional(t => t.SalesTerritory)
            //    .WithMany(t => t.Customers)
            //    .HasForeignKey(d => d.TerritoryID);
            //this.HasOptional(t => t.Store)
            //    .WithMany(t => t.Customers)
            //    .HasForeignKey(d => d.StoreID);

        }
    }
}
