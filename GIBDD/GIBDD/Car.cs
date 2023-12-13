namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [Key]
        public int id_car { get; set; }

        [Required]
        [StringLength(100)]
        public string category { get; set; }

        [Required]
        [StringLength(100)]
        public string vin { get; set; }

        [Required]
        [StringLength(100)]
        public string brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        [StringLength(100)]
        public string colour { get; set; }

        [Required]
        [StringLength(100)]
        public string region_of_registration { get; set; }

        [StringLength(10)]
        public string car_numbers { get; set; }

        public int id_offender { get; set; }

        public virtual Offender Offender { get; set; }
    }
}
