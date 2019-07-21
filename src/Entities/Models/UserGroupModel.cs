using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_usergroup")]
   public sealed class UserGroupModel
    {
        [Key]
        public int usergroupid_ { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        [Required]
        public int userid_ { get; set; }
        /// <summary>
        /// 团队id
        /// </summary>
        [Required]
        public int groupid_ { get; set; }
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

        [ForeignKey("userid_")]
        public UsersModel User { get; set; }

        [ForeignKey("groupid_")]
        public GroupsModel Group { get; set; }
    }
}
