using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DartLeagueManager.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }


    }
}
