using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class TechnicianSession
    {
        private ISession session { get; set; }
        private const string key = "technician";

        public TechnicianSession(ISession session)
        {
            this.session = session;
        }

        // set id, use string for id maybe
        public void SetId(int id) => session.SetObject<int>(key, id);

        // get id, return -1 if not found
        public int GetId()
        {
            var value = session.GetObject<int>(key);
            return (value == 0) ? -1 : (int)value;
        }
    }
}
