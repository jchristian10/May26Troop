using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TeamMVC.Data.Models
{
    public class Team
    {
        [Key]//Declares this to be the primary key for this database.
        public int TeamId { get; set; }
        [Required] //Makes the data 'Non-Nullable' in the database table.
        public string Name { get; set; }
        [Required]//Makes the data 'Non-Nullable' in the database table.
        public string City { get; set; }
        //The virtual keyword here allows this field to be overridden
        public virtual ICollection<Player> Players { get; set; }


    }
}
