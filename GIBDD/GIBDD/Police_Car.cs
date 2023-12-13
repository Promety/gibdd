namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Police_Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Police_Car()
        {
            Issuance_car = new HashSet<Issuance_car>();
            Mechanic_Police_Car = new HashSet<Mechanic_Police_Car>();
            Reception_car = new HashSet<Reception_car>();
        }

        [Key]
        public int id_police_car { get; set; }

        [Required]
        [StringLength(10)]
        public string car_number { get; set; }

        [Required]
        [StringLength(100)]
        public string VIN { get; set; }

        [Required]
        [StringLength(100)]
        public string brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        [StringLength(100)]
        public string colour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issuance_car> Issuance_car { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mechanic_Police_Car> Mechanic_Police_Car { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception_car> Reception_car { get; set; }
    }
}
