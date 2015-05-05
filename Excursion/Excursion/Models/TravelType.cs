using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 旅游类别表
    /// </summary>
    public class TravelType
    {
        /// <summary>
        /// 旅游Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 旅游类别
        /// </summary>
        public string TrType { get; set; }
    }
}