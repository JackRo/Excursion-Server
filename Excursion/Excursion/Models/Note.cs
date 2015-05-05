using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 根贴
    /// </summary>
    public class Note
    {
        /// <summary>
        /// 根贴Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 根贴用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 根贴内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 根贴标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 根贴创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int PraiseNum { get; set; }

        /// <summary>
        /// 是否点赞
        /// </summary>
        public bool IsPraise { get; set; }

        /// <summary>
        /// 是否交易
        /// </summary>
        public bool IsDeal { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public float Money { get; set; }
    }
}