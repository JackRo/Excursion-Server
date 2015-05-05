using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// 评论Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 评论的用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CommenTime { get; set; }
    }
}