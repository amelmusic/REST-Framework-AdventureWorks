using AdventureWorks.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureWorks.Services.Mapping
{
    public class EmployeeDepartmentHistoryMap : EntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.DepartmentID, t.ShiftID, t.StartDate });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DepartmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EmployeeDepartmentHistory", "HumanResources");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.DepartmentID).HasColumnName("DepartmentID");
            this.Property(t => t.ShiftID).HasColumnName("ShiftID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Department)
                .WithMany()
                .HasForeignKey(d => d.DepartmentID);
            this.HasRequired(t => t.Employee)
                .WithMany()
                .HasForeignKey(d => d.BusinessEntityID);
            //this.HasRequired(t => t.Shift)
            //    .WithMany(t => t.EmployeeDepartmentHistories)
            //    .HasForeignKey(d => d.ShiftID);

        }
    }
}
