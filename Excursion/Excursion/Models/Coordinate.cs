using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 景点坐标表
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// 坐标Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public float Latitude { get; set; }
    }
}