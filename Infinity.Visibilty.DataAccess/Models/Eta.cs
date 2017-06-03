using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Visibilty.DataAccess.Models
{
    public class Eta
    {

        public int tractor_id { get; set; }
        public int driver_id { get; set; }

        public int trip_id { get; set; }
        public int stop_nbr { get; set; }
        public int load_id { get; set; }

        public string org_loc_type { get;set;}

        public string dest_loc_type { get; set; }


        public DateTime load_due_date { get; set; }

        public decimal org_loc_lat { get; set; }


        public decimal org_loc_log { get; set; }


        public decimal dest_loc_lat { get; set; }


        public decimal dest_loc_log { get; set; }


        public decimal? percentage_complete { get; set; }
    }
}
