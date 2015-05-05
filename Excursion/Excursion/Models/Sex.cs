using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 性别表
    /// </summary>
    public class Sex
    {
        /// <summary>
        /// 性别Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }
    }
}