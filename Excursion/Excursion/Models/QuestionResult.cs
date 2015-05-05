using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excursion.Models
{
    /// <summary>
    /// 问题答案表
    /// </summary>
    public class QuestionResult
    {
        /// <summary>
        /// 问题答案Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 问题Id
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// 答案Id
        /// </summary>
        public int ResultId { get; set; }
    }
}