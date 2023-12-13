namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mechanic")]
    public partial class Mechanic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mechanic()
        {
            Mechanic_Police_Car = new HashSet<Mechanic_Police_Car>();
        }

        [Key]
        public int id_mechanic { get; set; }

        [Required]
        [StringLength(255)]
        public string last_name { get; set; }

        [Required]
        [StringLength(255)]
        public string first_name { get; set; }

        [Required]
        [StringLength(255)]
        public string patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthday_date { get; set; }

        [Required]
        [StringLength(4)]
        public string passport_series { get; set; }

        [Required]
        [StringLength(6)]
        public string passport_number { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        [Required]
        [StringLength(200)]
        public string rank { get; set; }

        [Required]
        [StringLength(255)]
        public string Country { get; set; }

        [Required]
        [StringLength(255)]
        public string Locality { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [Required]
        [StringLength(30)]
        public string Home_number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mechanic_Police_Car> Mechanic_Police_Car { get; set; }
    }
}
