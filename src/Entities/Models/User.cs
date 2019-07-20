using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("core_tb_user")]
    public class User
    {
        [Key]        
        public Guid UserId { get; set; }

        [StringLength(36)]
        public string UserName { get; set; }

        [StringLength(36)]
        public string UserAccount { get; set; }

        [StringLength(4)]
        public string Gender { get; set; }

        [StringLength(256)]
        public string Mail { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public Guid OrgId { get; set; }

        [StringLength(128)]
        public string OrgName { get; set; }

        public Guid CompanyId { get; set; }

        [StringLength(128)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int EmplyeeType { get; set; }

        public int DelFlag { get; set; }

        public int IsVaild { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(512)]
        public string PassStandard { get; set; }

        public int LoginNum { get; set; }

        public DateTime? LastDate { get; set; }

        public Guid? CreateUser { get; set; }

        [StringLength(36)]
        public string Code { get; set; }

        public int? ShowType { get; set; }

        [StringLength(128)]
        public string OaId { get; set; }

        [StringLength(128)]
        public string OfficePhone { get; set; }

    }
}
