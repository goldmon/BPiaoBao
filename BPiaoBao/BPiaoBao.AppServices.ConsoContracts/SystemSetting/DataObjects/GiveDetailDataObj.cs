﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.AppServices.ConsoContracts.SystemSetting.DataObjects
{
    public class GiveDetailDataObj
    {
        public string GiveCode { get; set; }
        public string GiveName { get; set; }
        /// <summary>
        /// 赠予条数
        /// </summary>
        public int GiveCount { get; set; }
        /// <summary>
        /// 赠送时间
        /// </summary>
        public DateTime GiveTime { get; set; }
        /// <summary>
        /// 赠送原因
        /// </summary>
        public string Remark { get; set; } 
    }
}