using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class vStoreWithDemographicMap : EntityTypeConfiguration<vStoreWithDemographic>
    {
        public vStoreWithDemographicMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.Name });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BankName)
                .HasMaxLength(50);

            this.Property(t => t.BusinessType)
                .HasMaxLength(5);

            this.Property(t => t.Specialty)
                .HasMaxLength(50);

            this.Property(t => t.Brands)
                .HasMaxLength(30);

            this.Property(t => t.Internet)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("vStoreWithDemographics", "Sales");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AnnualSales).HasColumnName("AnnualSales");
            this.Property(t => t.AnnualRevenue).HasColumnName("AnnualRevenue");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.BusinessType).HasColumnName("BusinessType");
            this.Property(t => t.YearOpened).HasColumnName("YearOpened");
            this.Property(t => t.Specialty).HasColumnName("Specialty");
            this.Property(t => t.SquareFeet).HasColumnName("SquareFeet");
            this.Property(t => t.Brands).HasColumnName("Brands");
            this.Property(t => t.Internet).HasColumnName("Internet");
            this.Property(t => t.NumberEmployees).HasColumnName("NumberEmployees");
        }
    }
}
