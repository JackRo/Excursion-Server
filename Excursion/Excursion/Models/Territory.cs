using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 地域
    /// </summary>
    public class Territory
    {
        /// <summary>
        /// 地域Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        public string Name { get; set; }
    }
}