using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 根贴的回复贴
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// 根贴的回复贴Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 根贴的回复贴用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 根贴的回复贴创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 根贴的回复贴图片地址
        /// </summary>
        public string ImageUrl { get; set; }
    }
}