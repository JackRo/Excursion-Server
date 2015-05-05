using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 花名库
    /// </summary>
    public class Stage
    {
        /// <summary>
        /// 花名Id，主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别Id
        /// </summary>
        public int SexId { get; set; }

        /// <summary>
        /// 性格Id
        /// </summary>
        public int NatureId { get; set; }

        /// <summary>
        /// 地域Id
        /// </summary>
        public int TerritoryId { get; set; }

        /// <summary>
        /// 人物出处Id
        /// </summary>
        public int ProvenaceId { get; set; }
    }
}