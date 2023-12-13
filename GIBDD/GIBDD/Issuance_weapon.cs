namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Issuance_weapon
    {
        [Key]
        public int id_issuance_weapon { get; set; }

        [Required]
        [StringLength(10)]
        public string serial_number { get; set; }

        [Required]
        [StringLength(10)]
        public string card_number { get; set; }

        [Required]
        [StringLength(100)]
        public string tipe { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        public DateTime time_of_issue_weapon { get; set; }

        [Required]
        [StringLength(100)]
        public string state { get; set; }

        [Required]
        [StringLength(100)]
        public string quantity_bullets { get; set; }

        public int id_service_weapon { get; set; }

        public virtual Service_weapon Service_weapon { get; set; }
    }
}
