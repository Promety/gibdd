namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Offense")]
    public partial class Offense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offense()
        {
            Offender_Offense = new HashSet<Offender_Offense>();
        }

        [Key]
        public int id_offense { get; set; }

        [Required]
        [StringLength(255)]
        public string tipe_of_violation { get; set; }

        [Required]
        [StringLength(255)]
        public string series_of_documents { get; set; }

        [Required]
        [StringLength(255)]
        public string document_Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_preparation { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_violation { get; set; }

        [Required]
        [StringLength(255)]
        public string type_of_intoxication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offender_Offense> Offender_Offense { get; set; }
    }
}
