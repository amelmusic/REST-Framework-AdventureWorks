using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class EmployeePayHistoryMap : EntityTypeConfiguration<EmployeePayHistory>
    {
        public EmployeePayHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.RateChangeDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EmployeePayHistory", "HumanResources");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.RateChangeDate).HasColumnName("RateChangeDate");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.PayFrequency).HasColumnName("PayFrequency");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeePayHistories)
                .HasForeignKey(d => d.BusinessEntityID);

        }
    }
}
