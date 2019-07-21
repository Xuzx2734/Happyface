using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_projectgroup")]
    public sealed class ProjectGroupModel
    {
        [Key]
        public int projectgroupid_ { get; set; }
        /// <summary>
        /// 项目id
        /// </summary>
        [Required]
        public int projectid_ { get; set; }
        /// <summary>
        /// 团队id
        /// </summary>
        [Required]
        public int groupid_ { get; set; }

        [ForeignKey("groupid_")]
        public GroupsModel Group { get; set; }

        [ForeignKey("projectid_")]
        public ProjectModel Project { get; set; }
    }
}
