namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inspector_offender
    {
        [Key]
        public int id_inspector_offender { get; set; }

        public int id_inspector { get; set; }

        public int id_offender { get; set; }

        public virtual Inspector Inspector { get; set; }

        public virtual Offender Offender { get; set; }
    }
}
