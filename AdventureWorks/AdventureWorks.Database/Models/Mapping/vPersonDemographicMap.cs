using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class vPersonDemographicMap : EntityTypeConfiguration<vPersonDemographic>
    {
        public vPersonDemographicMap()
        {
            // Primary Key
            this.HasKey(t => t.BusinessEntityID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MaritalStatus)
                .HasMaxLength(1);

            this.Property(t => t.YearlyIncome)
                .HasMaxLength(30);

            this.Property(t => t.Gender)
                .HasMaxLength(1);

            this.Property(t => t.Education)
                .HasMaxLength(30);

            this.Property(t => t.Occupation)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("vPersonDemographics", "Sales");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.TotalPurchaseYTD).HasColumnName("TotalPurchaseYTD");
            this.Property(t => t.DateFirstPurchase).HasColumnName("DateFirstPurchase");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.MaritalStatus).HasColumnName("MaritalStatus");
            this.Property(t => t.YearlyIncome).HasColumnName("YearlyIncome");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.TotalChildren).HasColumnName("TotalChildren");
            this.Property(t => t.NumberChildrenAtHome).HasColumnName("NumberChildrenAtHome");
            this.Property(t => t.Education).HasColumnName("Education");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.HomeOwnerFlag).HasColumnName("HomeOwnerFlag");
            this.Property(t => t.NumberCarsOwned).HasColumnName("NumberCarsOwned");
        }
    }
}
