using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 攻略表
    /// </summary>
    public class Strategy
    {
        /// <summary>
        /// 攻略Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 攻略内容
        /// </summary>
        public string StContent { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 景点Id
        /// </summary>
        public int ScenicSpotsId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}