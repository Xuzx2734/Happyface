using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_groups")]
    public sealed class GroupsModel
    {
        [Key]
        public int groupid_ { get; set; }
        /// <summary>
        /// 团队名称
        /// </summary>
        [Required]
        [StringLength(30)]
        public string name_ { get; set; }
        /// <summary>
        /// 团队说明
        /// </summary>
        [StringLength(100)]
        public string comment_ { get; set; }
        /// <summary>
        /// 新增时间
        /// </summary>
        [Required]
        public DateTime idate_ { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Required]
        public DateTime udate_ { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        [Required]
        public int delflag_ { get; set; }

        public ICollection<UserGroupModel> UserGroups { get; set; }

        public ICollection<ProjectGroupModel> ProjectGroups { get; set; }
    }
}
