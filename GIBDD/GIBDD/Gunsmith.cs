namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gunsmith")]
    public partial class Gunsmith
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gunsmith()
        {
            Gunsmith_Service_weapon = new HashSet<Gunsmith_Service_weapon>();
        }

        [Key]
        public int id_gunsmith { get; set; }

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
        public virtual ICollection<Gunsmith_Service_weapon> Gunsmith_Service_weapon { get; set; }
    }
}
