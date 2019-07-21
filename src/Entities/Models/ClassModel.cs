using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_class")]
    public sealed class ClassModel
    {
        [Key]
        public int classid_ { get; set; }
        /// <summary>
        /// 父目录id
        /// </summary>
        [Required]
        public int pid_ { get; set; }
        /// <summary>
        /// 目录名称
        /// </summary>
        [Required]
        [StringLength(30)]
        public string name_ { get; set; }

        [Required]
        public int sort_ { get; set; }

        [Required]
        public DateTime idate_ { get; set; }

        [Required]
        public DateTime udate_ { get; set; }

        [Required]
        public int delflag_ { get; set; }
        
        public ICollection<DocModel> Docs { get; set; }
                
    }
}
