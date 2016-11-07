using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class SalesTerritoryHistoryMap : EntityTypeConfiguration<SalesTerritoryHistory>
    {
        public SalesTerritoryHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.TerritoryID, t.StartDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TerritoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SalesTerritoryHistory", "Sales");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.SalesPerson)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.SalesTerritory)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.TerritoryID);

        }
    }
}
