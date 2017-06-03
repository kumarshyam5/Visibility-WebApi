namespace Infinity.Visibilty.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trailer")]
    public partial class trailer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? trailerNbr { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        [StringLength(4)]
        public string trailer_type_code { get; set; }
    }
}
