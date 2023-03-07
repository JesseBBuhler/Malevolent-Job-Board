using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Malevolent_Job_Board.Models
{
    public class PositionType
    {
        [Key]
        [Required]
        public int PositionTypeID { get; set; }
        [Required]
        public string PositionTypeDesc { get; set; }
    }
}
