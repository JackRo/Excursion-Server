using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 回复贴的回复贴
    /// </summary>
    public class AnswerSon
    {
        /// <summary>
        /// 回复贴的回复贴Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 回复贴的回复贴用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 回复贴的回复贴创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 回复贴的回复贴内容
        /// </summary>
        public string Content { get; set; }
    }
}