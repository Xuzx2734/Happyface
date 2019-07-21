using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_values")]
    public sealed class ValuesModel
    {
        [Key]
        public int valuesid_ { get; set; }
        /// <summary>
        /// 接口id
        /// </summary>
        [Required]
        public int docid_ { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required]
        public int type_ { get; set; }
        /// <summary>
        /// 外链
        /// </summary>
        public int link_ { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string content_ { get; set; }
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

        [ForeignKey("docid_")]
        public DocModel Doc { get; set; }
    }
}
