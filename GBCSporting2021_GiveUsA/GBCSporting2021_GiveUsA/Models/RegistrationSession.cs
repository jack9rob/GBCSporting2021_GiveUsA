using Microsoft.AspNetCore.Http;

namespace GBCSporting2021_GiveUsA.Models
{
    public class RegistrationSession
    {
        private ISession session { get; set; }

        public RegistrationSession(ISession session)
        {
            this.session = session;
        }

        // set id, use string for id maybe
        public void SetId(int id)
        {
            session.SetInt32("customer", id);
        }

        // get id, return -1 if not found
        public int GetId()
        {
            var value = session.GetInt32("customer");
            return (value == null) ? -1 : (int)value;
        }
    }
}
