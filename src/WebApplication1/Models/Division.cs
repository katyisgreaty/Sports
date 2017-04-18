using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    [Table("Divisions")]
    public class Division
    {
        public Division()
        {
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public string Name { get; set; }
        public string Skill { get; set; }
        public int Number { get; set; }
        public int DivisionId { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
