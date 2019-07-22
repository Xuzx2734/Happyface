using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_users")]
    public sealed class UsersModel
    {
        [Key]
        public int userid_ { get; set; }
        /// <summary>
        /// 登录帐号
        /// </summary>
        [Required]
        [StringLength(20)]
        public string code_ { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        [StringLength(20)]
        public string pass_ { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(20)]
        public string email_ { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [StringLength(50)]
        public string name_ { get; set; }
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

        public ICollection<DocModel> Docs { get; set; }

    }
}
