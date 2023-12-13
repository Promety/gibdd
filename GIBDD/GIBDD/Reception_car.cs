namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reception_car
    {
        [Key]
        public int id_reception_car { get; set; }

        [Required]
        [StringLength(10)]
        public string car_number { get; set; }

        [Required]
        [StringLength(100)]
        public string number_waybill { get; set; }

        [Required]
        [StringLength(100)]
        public string mileage { get; set; }

        [Required]
        [StringLength(100)]
        public string fuel_consumption { get; set; }

        public DateTime Time_of_receipt_car { get; set; }

        [Required]
        [StringLength(100)]
        public string state { get; set; }

        public int id_police_car { get; set; }

        public virtual Police_Car Police_Car { get; set; }
    }
}
