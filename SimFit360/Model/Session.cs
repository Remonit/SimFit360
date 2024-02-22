using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimFit360.Model
{
    public class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string SessionPartId { get; set; }
        public ICollection<SessionPart> SessionParts { get; set; }
    }
}
