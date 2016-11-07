using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class PersonPhoneMap : EntityTypeConfiguration<PersonPhone>
    {
        public PersonPhoneMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.PhoneNumber, t.PhoneNumberTypeID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.PhoneNumberTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonPhone", "Person");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.PhoneNumberTypeID).HasColumnName("PhoneNumberTypeID");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.PhoneNumberType)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.PhoneNumberTypeID);

        }
    }
}
