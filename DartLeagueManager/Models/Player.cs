using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DartLeagueManager.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string AssociationId { get; set; }

        public string ADAId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
