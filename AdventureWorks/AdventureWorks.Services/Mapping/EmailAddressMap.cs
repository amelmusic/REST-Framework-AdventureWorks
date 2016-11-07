using AdventureWorks.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdventureWorks.Services.Mapping
{
    public class EmailAddressMap : EntityTypeConfiguration<EmailAddress>
    {
        public EmailAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailAddressID);

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmailAddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EmailAddress1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmailAddress", "Person");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.EmailAddressID).HasColumnName("EmailAddressID");
            this.Property(t => t.EmailAddress1).HasColumnName("EmailAddress");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            //// Relationships
            //this.HasRequired(t => t.Person)
            //    .WithMany(t => t.EmailAddresses)
            //    .HasForeignKey(d => d.BusinessEntityID);
            
        }
    }
}
