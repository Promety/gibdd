namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Withdrawal_DL
    {
        [Key]
        public int id_withdrawal_DL { get; set; }

        [Column(TypeName = "date")]
        public DateTime from { get; set; }

        [Column(TypeName = "date")]
        public DateTime before { get; set; }

        [Required]
        [StringLength(10)]
        public string driver_license_number { get; set; }

        public int id_offender { get; set; }

        public virtual Offender Offender { get; set; }
    }
}
