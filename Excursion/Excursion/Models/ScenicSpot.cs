using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 景点表
    /// </summary>
    public class ScenicSpot
    {
        /// <summary>
        /// 景点Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 景点描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 景点图片
        /// </summary>
        public string SsImage { get; set; }

        /// <summary>
        /// 景点地址
        /// </summary>
        public int Address { get; set; }
    }
}