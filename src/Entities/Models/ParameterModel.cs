using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("t_parameter")]
    public sealed class ParameterModel
    {
        [Key]
        public int parameterid_ { get; set; }
        /// <summary>
        /// 接口id
        /// </summary>
        [Required]
        public int docid_ { get; set; }
        /// <summary>
        /// 参数名称
        /// </summary>
        [Required]
        [StringLength(30)]
        public string parameter_ { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        [Required]
        public int type_ { get; set; }
        /// <summary>
        /// /参数说明
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

        [ForeignKey("docid_")]
        public DocModel Doc { get; set; }
    }
}
