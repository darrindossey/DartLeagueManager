using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DartLeagueManager.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }

        public string AssociationId { get; set; }

        public string ADAId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
