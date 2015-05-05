using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 人物出处
    /// </summary>
    public class Provenace
    {
        /// <summary>
        /// 人物出处Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 出处类型
        /// </summary>
        public string ProStyle { get; set; }
    }
}