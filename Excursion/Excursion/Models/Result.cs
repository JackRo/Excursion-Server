using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 答案表
    /// </summary>
    public class Result
    {
        /// <summary>
        /// 答案Id
        /// </summary>
        public int Id { get; set; }

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