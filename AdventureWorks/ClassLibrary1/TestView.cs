namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestView")]
    public partial class TestView
    {
        [Key]
        [Column(Order = 0)]
        public int ContactTypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ModifiedDate { get; set; }

        public string Description { get; set; }
    }
}
