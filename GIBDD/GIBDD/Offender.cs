namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Offender")]
    public partial class Offender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offender()
        {
            Car = new HashSet<Car>();
            inspector_offender = new HashSet<inspector_offender>();
            Offender_Offense = new HashSet<Offender_Offense>();
            Resolution = new HashSet<Resolution>();
            Withdrawal_DL = new HashSet<Withdrawal_DL>();
        }

        [Key]
        public int id_offender { get; set; }

        [Required]
        [StringLength(255)]
        public string last_name { get; set; }

        [Required]
        [StringLength(255)]
        public string first_name { get; set; }

        [Required]
        [StringLength(255)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

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
        [StringLength(10)]
        public string driver_license_number { get; set; }

        [Required]
        [StringLength(10)]
        public string osago_policy { get; set; }

        [Required]
        [StringLength(255)]
        public string citizenship { get; set; }

        [Required]
        [StringLength(10)]
        public string TIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Car { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inspector_offender> inspector_offender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offender_Offense> Offender_Offense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resolution> Resolution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Withdrawal_DL> Withdrawal_DL { get; set; }
    }
}
