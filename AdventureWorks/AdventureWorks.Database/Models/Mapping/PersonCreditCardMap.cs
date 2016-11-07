using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace  AdventureWorks.Model.Mapping
{
    public class PersonCreditCardMap : EntityTypeConfiguration<PersonCreditCard>
    {
        public PersonCreditCardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BusinessEntityID, t.CreditCardID });

            // Properties
            this.Property(t => t.BusinessEntityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreditCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonCreditCard", "Sales");
            this.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID");
            this.Property(t => t.CreditCardID).HasColumnName("CreditCardID");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonCreditCards)
                .HasForeignKey(d => d.BusinessEntityID);
            this.HasRequired(t => t.CreditCard)
                .WithMany(t => t.PersonCreditCards)
                .HasForeignKey(d => d.CreditCardID);

        }
    }
}
