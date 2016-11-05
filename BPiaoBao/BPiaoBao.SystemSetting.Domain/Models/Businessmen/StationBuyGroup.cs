﻿using JoveZhao.Framework.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.SystemSetting.Domain.Models.Businessmen
{
    public class StationBuyGroup : EntityBase, IAggregationRoot
    {
        public static string NewID() 
        {
            return Guid.NewGuid().ToString().ToLower();
        }

        protected override string GetIdentity()
        {
            return ID;
        }
        /// <summary>
        /// 组ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 组名
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 最后操作人
        /// </summary>
        public string LastOperatorUser { get; set; }
        /// <summary>
        /// 最后操作时间
        /// </summary>
        public DateTime LastOperatTime { get; set; }
    }
}
