using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_doc")]
    public sealed class DocModel
    {
        [Key]
        public int docid_ { get; set; }
        /// <summary>
        /// 项目id
        /// </summary>
        [Required]
        public int name_ { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int userid_ { get; set; }
        /// <summary>
        /// 文档目录
        /// </summary>
        [Required]
        public int class_ { get; set; }
        /// <summary>
        /// 文档标题
        /// </summary>
        [Required]
        [StringLength(100)]
        public string title_ { get; set; }
        /// <summary>
        /// 文档类别
        /// </summary>
        [Required]
        public int type_ { get; set; }
        /// <summary>
        /// 文档内容
        /// </summary>
        public string content_ { get; set; }
        /// <summary>
        /// 方法名
        /// </summary>
        [Required]
        [StringLength(10)]
        public string function_ { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public DateTime delflag_ { get; set; }

        [ForeignKey("class_")]
        public ClassModel Class { get; set; }

        [ForeignKey("name_")]
        public ProjectModel Project { get; set; }

        [ForeignKey("userid_")]
        public UsersModel User { get; set; }

        public ICollection<ValuesModel> Values { get; set; }

        public ICollection<ParameterModel> Parameters { get; set; }

    }
}
