namespace GIBDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mechanic_Police_Car
    {
        [Key]
        public int id_mechanic_police_car { get; set; }

        public int id_mechanic { get; set; }

        public int id_police_car { get; set; }

        public virtual Mechanic Mechanic { get; set; }

        public virtual Police_Car Police_Car { get; set; }
    }
}
