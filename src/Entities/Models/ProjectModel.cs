using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_project")]
    public sealed class ProjectModel
    {
        [Key]
        public int projectid_ { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [Required]
        [StringLength(20)]
        public string name_ { get; set; }
        /// <summary>
        /// 项目状态
        /// </summary>
        [Required]
        public int state_ { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required]
        public int userid_ { get; set; }
        /// <summary>
        /// 项目说明
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

        public ICollection<ProjectGroupModel> ProjectGroups { get; set; }

        public ICollection<DocModel> Docs { get; set; }

    }
}
