namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Offender_Offense
    {
        [Key]
        public int id_offender_offense { get; set; }

        public int id_offender { get; set; }

        public int id_offense { get; set; }

        public virtual Offender Offender { get; set; }

        public virtual Offense Offense { get; set; }
    }
}
