namespace Infinity.Visibilty.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trip_movement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trip_movement_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trip_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stop_nbr { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int load_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string org_loc_type { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int org_loc_id { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string dest_loc_type { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dest_loc_id { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal org_loc_lat { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal org_loc_log { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal dest_loc_lat { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal dest_loc_log { get; set; }

        public DateTime? load_due_date { get; set; }
    }
}
