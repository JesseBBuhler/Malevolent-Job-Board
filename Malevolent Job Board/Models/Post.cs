using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Malevolent_Job_Board.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int PostID { get; set; }
        [Required]
        public string PositionTitle { get; set; }
        [Required]
        public string Company { get; set; }
        public int PositionTypeID { get; set; }
        public PositionType PositionType { get; set; }
        [Required]
        public string Description { get; set; }
        public int Salary { get; set; }
        

    }
}
