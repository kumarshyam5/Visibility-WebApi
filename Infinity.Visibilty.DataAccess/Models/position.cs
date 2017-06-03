namespace Infinity.Visibilty.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("position")]
    public partial class position
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long transaction_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime transaction_ts { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tractor_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal latitude { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal logitutde { get; set; }
    }
}
