namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inspector")]
    public partial class Inspector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspector()
        {
            inspector_offender = new HashSet<inspector_offender>();
        }

        [Key]
        public int id_inspector { get; set; }

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

        [Required]
        [StringLength(6)]
        public string token_number { get; set; }

        [Required]
        [StringLength(6)]
        public string card_number { get; set; }

        [Required]
        [StringLength(10)]
        public string number_waybill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inspector_offender> inspector_offender { get; set; }
    }
}
