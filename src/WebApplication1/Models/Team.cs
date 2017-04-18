using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Players { get; set; }
        public string Captain { get; set; }
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public virtual Division Division { get; set; }
    }
}
