using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 性格表
    /// </summary>
    public class Nature
    {
        /// <summary>
        /// 性格Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 性格类别
        /// </summary>
        public string NType { get; set; }
    }
}