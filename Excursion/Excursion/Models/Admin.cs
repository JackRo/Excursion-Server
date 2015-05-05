using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 后台管理员
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// 后台管理员Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 后台管理员登录用户名
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// 后台管理员登录密码
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}