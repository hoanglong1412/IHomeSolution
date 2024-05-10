﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MockProject.API.Models
{
    public class Coupon
    {
        #region PK
        [Key]
        public int CouponId { get; set; }
        #endregion

        #region Column
        [Column(TypeName = "int")]
        public int Point { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column(TypeName = "int")]
        public int Status { get; set; }
        #endregion

        #region FK
        public int StaffId { get; set; }
        [ForeignKey("StaffId")]
        public virtual AdminUser? AdminUser { get; set; }
        #endregion
    }
}
