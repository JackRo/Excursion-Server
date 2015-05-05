using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 问题表
    /// </summary>
    public class Question
    {
        /// <summary>
        /// 问题Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        public string Content { get; set; }
    }
}