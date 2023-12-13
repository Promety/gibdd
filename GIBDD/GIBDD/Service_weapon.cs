namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service_weapon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service_weapon()
        {
            Gunsmith_Service_weapon = new HashSet<Gunsmith_Service_weapon>();
            Issuance_weapon = new HashSet<Issuance_weapon>();
            Reception_weapon = new HashSet<Reception_weapon>();
        }

        [Key]
        public int id_service_weapon { get; set; }

        public int serial_number { get; set; }

        [Required]
        [StringLength(100)]
        public string tipe { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [Required]
        [StringLength(100)]
        public string weight { get; set; }

        [Required]
        [StringLength(100)]
        public string sighting_range { get; set; }

        [Required]
        [StringLength(100)]
        public string bullet_speed { get; set; }

        [Required]
        [StringLength(100)]
        public string rate_of_fire { get; set; }

        [Required]
        [StringLength(100)]
        public string capacity { get; set; }

        [Required]
        [StringLength(100)]
        public string weapon_length { get; set; }

        [Required]
        [StringLength(100)]
        public string weapon_height { get; set; }

        [Required]
        [StringLength(30)]
        public string caliber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gunsmith_Service_weapon> Gunsmith_Service_weapon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuance_weapon> Issuance_weapon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception_weapon> Reception_weapon { get; set; }
    }
}
