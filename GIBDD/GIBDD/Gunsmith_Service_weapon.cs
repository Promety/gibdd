namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gunsmith_Service_weapon
    {
        [Key]
        public int id_gunsmith_service_weapon { get; set; }

        public int id_gunsmith { get; set; }

        public int id_service_weapon { get; set; }

        public virtual Gunsmith Gunsmith { get; set; }

        public virtual Service_weapon Service_weapon { get; set; }
    }
}
