using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class BusinessEntityContactMap : EntityTypeConfiguration<BusinessEntityContact>
    {
        public BusinessEntityContactMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.PersonID, t.ContactTypeID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PersonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContactTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BusinessEntityContact", "Person");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.ContactTypeID).HasColumnName("ContactTypeID");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.BusinessEntity)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.ContactType)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.ContactTypeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
