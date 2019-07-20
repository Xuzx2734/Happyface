using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("class")]
    public class ClassModel
    {
        [Key]
        [Column("id")]
        public int ClassId { get; set; }

        [Required]
        public int pid { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        public int sort { get; set; }

        [Required]
        public DateTime idate { get; set; }

        [Required]
        public DateTime udate { get; set; }

        [Required]
        public int delflag { get; set; }

    }
}
