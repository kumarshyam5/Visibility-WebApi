namespace Infinity.Visibilty.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class store_trailer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? trailerId { get; set; }

        public int? storeNbr { get; set; }

        public int? trailerNbr { get; set; }

        public DateTime? arrival { get; set; }

        public DateTime? departure { get; set; }
    }
}
