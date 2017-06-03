using Infinity.Visibilty.DataAccess;
using Infinity.Visibilty.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Infinity.Visibilty.WebAPI.Controllers
{
    public class VisibilityController : ApiController
    {

        private VisibilityDbContext _context = new VisibilityDbContext();

        // GET: api/Visibility
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Visibility/5
        public Eta Get(int id)
        {
            var parameter = new SqlParameter("tractor_id", Convert.ToInt32(id));

            var ETA = _context.Database.SqlQuery<Eta>("sp_fetch_details_for_eta @tractor_id", parameter).FirstOrDefault();

            return ETA;
        }

        // POST: api/Visibility
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Visibility/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Visibility/5
        public void Delete(int id)
        {
        }
    }
}
