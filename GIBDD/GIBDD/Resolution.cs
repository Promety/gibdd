namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resolution")]
    public partial class Resolution
    {
        [Key]
        public int id_resolution { get; set; }

        [Required]
        [StringLength(4)]
        public string series_resolution { get; set; }

        [Required]
        [StringLength(6)]
        public string number_of_resolution { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_resolution { get; set; }

        [Required]
        [StringLength(255)]
        public string tocken_number { get; set; }

        [Required]
        [StringLength(255)]
        public string locality { get; set; }

        public int id_offender { get; set; }

        public virtual Offender Offender { get; set; }
    }
}
